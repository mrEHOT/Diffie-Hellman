using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math.Gmp.Native;

namespace Diffie_Hellman
{
    static class DiffieHellman
    {
        private static mpz_t p = "0"; // Статическая переменная для хранения простого числа p
        private static mpz_t q = "0"; // Статическая переменная для хранения числа q, такого что p = 2*q + 1
        private static mpz_t g = "0"; // Статическая переменная для хранения числа g
        private static mpz_t privateNumberA = "0"; // Статическая переменная для хранения секретного числа абонента A
        private static mpz_t privateNumberB = "0"; // Статическая переменная для хранения секретного числа абонента B
        private static mpz_t publicKeyA = "0"; // Статическая переменная для хранения открытого ключа абонента A
        private static mpz_t publicKeyB = "0"; // Статическая переменная для хранения открытого ключа абонента B
        private static mpz_t privateKeyA = "0"; // Статическая переменная для хранения секретного ключа абонента A
        private static mpz_t privateKeyB = "0"; // Статическая переменная для хранения секретного ключа абонента B


        private static bool CheckPrivateKey(mpz_t privateKeyA, mpz_t privateKeyB)
        {
            mpz_t xor = "0";
            gmp_lib.mpz_xor(xor, privateKeyA, privateKeyB); // Рассчитываем XOR для секретных ключей пользователей
            if (gmp_lib.mpz_cmp(xor, "0") == 0)
                return true;
            else
                return false;
        } // Проверка на совпадение секретного (сеансового ключа)

        public static (string, List<mpz_t>) DiffieHellmanSetup()
        {
            List<mpz_t> content = new List<mpz_t>(); // Список для хранения параметров шифра, которые необходимо вернуть
            (string, List<mpz_t>) result = ("", content); // Кортеж для формирования вывода функции

            #region Настройка генератора случайных чисел
            Random random = new Random();
            int seed = random.Next();
            gmp_randstate_t state = new gmp_randstate_t();
            gmp_lib.gmp_randinit_default(state);
            gmp_lib.gmp_randseed_ui(state, (uint)seed);
            #endregion

            gmp_lib.mpz_urandomb(q, state, 300);
            gmp_lib.mpz_nextprime(q, q); // Получаем простое q
            while (true)
            {
                gmp_lib.mpz_mul(p, q, "2"); // p = 2*q
                gmp_lib.mpz_add(p, p, "1"); // p = 2*q + 1

                if (SolovayStrassenTest.PrimalityTest(p))
                    break;
                else
                    gmp_lib.mpz_nextprime(q, q); // берем следующее простое число
            }

            g = "2"; // Задаем стартовое значение для g
            while (true)
            {
                if (gmp_lib.mpz_cmp(ModOperations.Pow(g, q, p), "1") != 0)
                    break;
                else
                    gmp_lib.mpz_add(g, g, "1");
            }

            gmp_lib.mpz_urandomm(privateNumberA, state, p); // Генерируем случайное число в диапазоне от 0 до N-1
            gmp_lib.mpz_urandomm(privateNumberB, state, p); // Генерируем случайное число в диапазоне от 0 до N-1

            content.Add(p);
            content.Add(q);
            content.Add(g);
            content.Add(privateNumberA);
            content.Add(privateNumberB);
            result.Item1 = "Ключи успешно сгенерированы";

            return result;
        } // Функция автоматически рассчитывает входные параметры шифра и возвращает их

        public static (bool, string, List<mpz_t>) DiffieHellmanSetup(mpz_t p, mpz_t privateNumberA, mpz_t privateNumberB)
        {
            List<mpz_t> content = new List<mpz_t>(); // Список для хранения параметров шифра, которые необходимо вернуть

            (bool, string, List<mpz_t>) result = (false, "", content); // Кортеж для формирования вывода функции

            if (SolovayStrassenTest.PrimalityTest(p))
            {

                DiffieHellman.p = p; // Запоминаем параметр p
                gmp_lib.mpz_mod(DiffieHellman.privateNumberA, privateNumberA, DiffieHellman.p); // Запоминаем значение privateNumberA, вычисленное по модулю p
                gmp_lib.mpz_mod(DiffieHellman.privateNumberB, privateNumberB, DiffieHellman.p); // Запоминаем значение privateNumberA, вычисленное по модулю p

                mpz_t temp = "0";
                gmp_lib.mpz_sub(temp, DiffieHellman.p, "1"); // Помещаем в p значение (p-1)
                gmp_lib.mpz_fdiv_q(DiffieHellman.q, temp, "2"); // Запоминаем параметр q = (p-1)/2

                if (!SolovayStrassenTest.PrimalityTest(DiffieHellman.q))
                    result.Item2 = "Ключи были сгенерированы! ЗАМЕЧАНИЕ: система не обладает высокой стойкостью, т.к. для выбранного p = 2*q + 1, q не явлется простым числом!";

                DiffieHellman.g = "2"; // Задаем стартовое значение для g

                while (true)
                {
                    if (gmp_lib.mpz_cmp(ModOperations.Pow(DiffieHellman.g, DiffieHellman.q, DiffieHellman.p), "1") != 0)
                    {
                        content.Add(DiffieHellman.p);
                        content.Add(DiffieHellman.q);
                        content.Add(DiffieHellman.g);
                        content.Add(DiffieHellman.privateNumberA);
                        content.Add(DiffieHellman.privateNumberB);

                        result.Item1 = true;

                        if (result.Item2.Length == 0)
                            result.Item2 = "Ключи успешно сгенерированы";

                        result.Item3 = content;

                        break; // Выходим, если нашли g удовлетворяющее условиям
                    }

                    else
                        gmp_lib.mpz_add(DiffieHellman.g, DiffieHellman.g, "1"); // Инкремент g
                }

                return result;
            } // Проверяем, что p является простым
            else
            {
                result.Item2 = "Ошибка генерации ключей! Число p не является простым!";
                return result;
            }

        } // Функция рассчитывает входные параметры шифра на основании пользовательского ввода и возвращает их

        public static (mpz_t, mpz_t) CalculateUsersPublicKeys()
        {
            publicKeyA = ModOperations.Pow(g, privateNumberA, p);
            publicKeyB = ModOperations.Pow(g, privateNumberB, p);

            return (publicKeyA, publicKeyB);
        } // Возвращаем открытые ключи пользователей

        public static (string, mpz_t, mpz_t) CalculateUsersPrivateKeys()
        {
            string result = "";
            privateKeyA = ModOperations.Pow(publicKeyB, privateNumberA, p);
            privateKeyB = ModOperations.Pow(publicKeyA, privateNumberB, p);

            if (CheckPrivateKey(privateKeyA, privateKeyB))
                result = "Общий секретный ключ получен! (XOR = 0)";
            else
                result = "Секретные ключи не совпадают!";

            return (result, privateKeyA, privateKeyB);
        } // Возвращаем закрытый ключ пользователей

        public static void DiffieHellmanReset()
        {
            p = "0"; // Статическая переменная для хранения простого числа p
            q = "0"; // Статическая переменная для хранения числа q, такого что p = 2*q + 1
            g = "0"; // Статическая переменная для хранения числа g
            privateNumberA = "0"; // Статическая переменная для хранения секретного числа абонента A
            privateNumberB = "0"; // Статическая переменная для хранения секретного числа абонента B
            publicKeyA = "0"; // Статическая переменная для хранения открытого ключа абонента A
            publicKeyB = "0"; // Статическая переменная для хранения открытого ключа абонента B
            privateKeyA = "0"; // Статическая переменная для хранения секретного ключа абонента A
            privateKeyB = "0"; // Статическая переменная для хранения секретного ключа абонента B
        } // Сброс шифра в начальное состояние
    }
}
