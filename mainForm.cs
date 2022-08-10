using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Math.Gmp.Native;

namespace Diffie_Hellman
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void manualRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (manualRadioButton.Checked)
            {
                // Включаем элементы управления
                pPrimeTextBox.ReadOnly = false;
                privateNumberATextBox.ReadOnly = false;
                privateNumberBTextBox.ReadOnly = false;
                startButton.Enabled = true;
            }
        } // Выбор ручного режима ввода данных

        private void autoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (autoRadioButton.Checked)
            {
                // Выключаем элементы управления
                pPrimeTextBox.ReadOnly = true;
                privateNumberATextBox.ReadOnly = true;
                privateNumberBTextBox.ReadOnly = true;

                // Включаем элементы управления
                startButton.Enabled = true;
            }
        } // Автоматическая выполнение алгоритма Диффи-Хеллмана

        private void startButton_Click(object sender, EventArgs e)
        {
            if (manualRadioButton.Checked)
            {
                var regex = new Regex(@"^[1-9]+\d{0,}$"); // Задаем регулярное выражение для проверки введенного текста
                if (regex.IsMatch(pPrimeTextBox.Text) && regex.IsMatch(privateNumberATextBox.Text) && regex.IsMatch(privateNumberBTextBox.Text))
                {
                    var startParameters = DiffieHellman.DiffieHellmanSetup(pPrimeTextBox.Text, privateNumberATextBox.Text, privateNumberBTextBox.Text);
                    if (startParameters.Item1)
                    {
                        var publicKeys = DiffieHellman.CalculateUsersPublicKeys(); // Рассчитываем открыте ключи
                        var privateKeys = DiffieHellman.CalculateUsersPrivateKeys(); // Рассчитываем закрытый ключ (ключи)

                        pPrimeTextBox.Text = startParameters.Item3[0].ToString();
                        qNumberTextBox.Text = startParameters.Item3[1].ToString();
                        gNumberTextBox.Text = startParameters.Item3[2].ToString();
                        privateNumberATextBox.Text = startParameters.Item3[3].ToString();
                        privateNumberBTextBox.Text = startParameters.Item3[4].ToString();
                        MessageBox.Show(startParameters.Item2, "Успешное выполнение", MessageBoxButtons.OK, MessageBoxIcon.Information); // Выводим сообщение на экран

                        publicKeyATextBox.Text = publicKeys.Item1.ToString();
                        publicKeyBTextBox.Text = publicKeys.Item2.ToString();

                        privateKeyATextBox.Text = privateKeys.Item2.ToString();
                        privateKeyBTextBox.Text = privateKeys.Item3.ToString();
                        privateKeyCheckTextBox.Text = privateKeys.Item1.ToString();
                    }
                    else
                    {
                        MessageBox.Show(startParameters.Item2, "Ошибка выполнения", MessageBoxButtons.OK, MessageBoxIcon.Error); // Выводим сообщение на экран
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Параметры заполнены некорректно! Повторите ввод!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } // Выполнение с учетом пользовательского ввода

            if (autoRadioButton.Checked)
            {
                var startParameters = DiffieHellman.DiffieHellmanSetup();
                var publicKeys = DiffieHellman.CalculateUsersPublicKeys(); // Рассчитываем открыте ключи
                var privateKeys = DiffieHellman.CalculateUsersPrivateKeys(); // Рассчитываем закрытый ключ (ключи)

                pPrimeTextBox.Text = startParameters.Item2[0].ToString();
                qNumberTextBox.Text = startParameters.Item2[1].ToString();
                gNumberTextBox.Text = startParameters.Item2[2].ToString();
                privateNumberATextBox.Text = startParameters.Item2[3].ToString();
                privateNumberBTextBox.Text = startParameters.Item2[4].ToString();
                MessageBox.Show(startParameters.Item1, "Успешное выполнение", MessageBoxButtons.OK, MessageBoxIcon.Information); // Выводим сообщение на экран

                publicKeyATextBox.Text = publicKeys.Item1.ToString();
                publicKeyBTextBox.Text = publicKeys.Item2.ToString();

                privateKeyATextBox.Text = privateKeys.Item2.ToString();
                privateKeyBTextBox.Text = privateKeys.Item3.ToString();
                privateKeyCheckTextBox.Text = privateKeys.Item1.ToString();
            } // Автоматическая генерация

            // Включаем элементы
            resetButton.Enabled = true;

            // Выключаем элементы
            startButton.Enabled = false;
            manualRadioButton.Enabled = false;
            autoRadioButton.Enabled = false;
            pPrimeTextBox.ReadOnly = true;
            privateNumberATextBox.ReadOnly = true;
            privateNumberBTextBox.ReadOnly = true;

        } // Выполнение процедуры открытого распределения ключей

        private void resetButton_Click(object sender, EventArgs e)
        {
            DiffieHellman.DiffieHellmanReset(); // Сбрасываем параметры алгоритма

            // Чистим текст боксы
            pPrimeTextBox.Clear();
            qNumberTextBox.Clear();
            gNumberTextBox.Clear();
            privateNumberATextBox.Clear();
            privateNumberBTextBox.Clear();
            publicKeyATextBox.Clear();
            publicKeyBTextBox.Clear();
            privateKeyATextBox.Clear();
            privateKeyBTextBox.Clear();
            privateKeyCheckTextBox.Clear();

            // Включаем элементы управления
            autoRadioButton.Enabled = true;
            manualRadioButton.Enabled = true;

            // Выключаем элементы управления
            resetButton.Enabled = false;
        } // Сброс программы в начальное состояние
    }
}
