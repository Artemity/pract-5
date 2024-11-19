using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using lib13;

namespace практическая_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Создание экземпляров класса Pair
        Pair pair1 = new Pair(0, 0);
        Pair pair2 = new Pair(0, 0);
        Pair pair3 = new Pair(0, 0);

        Rational rational1 = new Rational(0, 1); 
        Rational rational2 = new Rational(0, 1);
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие закрытия окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Событие "О программе"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программу выполнил студент группы ИСП-31 Лотаков Артемий\nПрактическая работа 7 Вариант 13\nИспользовать базовый класс Pair (пара целых чисел). Создать производный класс Rational; определить новые операции сложения (а, b) + (с, d) = (ad + be, bd) и деления (а, b)/ (с, d) = (ad, be); переопределить операцию вычитания (а, b) - (с, d) = (ad - be, bd)", "Информация о программе");
        }

        /// <summary>
        /// Событие "Сравнить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompare_Click(object sender, RoutedEventArgs e)
        {
            // Обновление текстовых полей значениями из пар
            firsrtPair1.Text = pair1.First.ToString();
            firsrtPair2.Text = pair1.Second.ToString();
            secondPair1.Text = pair2.First.ToString();
            secondPair2.Text = pair2.Second.ToString();
            thirdPair1.Text = pair3.First.ToString();
            thirdPair2.Text = pair3.Second.ToString();

            // Логика сравнения пар в зависимости от выбранных флажков
            // если первый элемент выбран, а второй и третий элементы не выбраны
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == false && thirdSelected.IsChecked == false)
                if (pair1)// Проверяет, равны ли элементы в паре
                {
                    MessageBox.Show("Пара равна", "Результат сравнения");
                }
                else MessageBox.Show("Пара не равна", "Результат сравнения");

            // если первый элемент не выбран, второй элемент выбран, а третий элемент не выбран
            if (firstSelected.IsChecked == false && secondSelected.IsChecked == true && thirdSelected.IsChecked == false)
            {
                if (pair2)
                {
                    MessageBox.Show("Пара равна", "Результат сравнения");
                }
                else MessageBox.Show("Пара не равна", "Результат сравнения");
            }
            //если первый элемент не выбран, второй элемент не выбран, а третий элемент выбран
            if (firstSelected.IsChecked == false && secondSelected.IsChecked == false && thirdSelected.IsChecked == true)
            {
                if (pair3)
                {
                    MessageBox.Show("Пара равна", "Результат сравнения");
                }
                else MessageBox.Show("Пара не равна", "Результат сравнения");
            }
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == true && thirdSelected.IsChecked == false)
            {
                if (pair1.Compare(pair2))
                {
                    MessageBox.Show("Пары равны", "Результат сравнения");
                }
                else MessageBox.Show("Пары не равны", "Результат сравнения");
            }
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == false && thirdSelected.IsChecked == true)
            {
                if (pair1.Compare(pair3))
                {
                    MessageBox.Show("Пары равны", "Результат сравнения");
                }
                else MessageBox.Show("Пары не равны", "Результат сравнения");
            }
            //если первый элемент не выбран, второй элемент выбран, а третий элемент выбран
            if (firstSelected.IsChecked == false && secondSelected.IsChecked == true && thirdSelected.IsChecked == true)
            {
                if (pair2.Compare(pair3))//Проверяет, равны ли пары pair2 и pair3 с помощью метода Compare(pair3)
                {
                    MessageBox.Show("Пары равны", "Результат сравнения");
                }
                else MessageBox.Show("Пары не равны", "Результат сравнения");
            }
            //если все элементы выбраны 
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == true && thirdSelected.IsChecked == true)
            {
                if (pair1.Compare(pair2, pair3))
                {
                    MessageBox.Show("Пары равны", "Результат сравнения");
                }
                else MessageBox.Show("Пары не равны", "Результат сравнения");
            }
        }

        /// <summary>
        /// Событие "Вычесть"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            // Обновление текстовых полей значениями из пар
            firsrtPair1.Text = pair1.First.ToString();
            firsrtPair2.Text = pair1.Second.ToString();
            secondPair1.Text = pair2.First.ToString();
            secondPair2.Text = pair2.Second.ToString();
            thirdPair1.Text = pair3.First.ToString();
            thirdPair2.Text = pair3.Second.ToString();

            Rational result = null; // Результат вычитания

            // Логика вычитания пар в зависимости от выбранных флажков
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == true && thirdSelected.IsChecked == false)
            {
                var rational1 = new Rational(pair1.First, pair1.Second);
                var rational2 = new Rational(pair2.First, pair2.Second);
                result = rational1 - rational2; // Используем переопределенную операцию вычитания из Rational
            }
            else if (firstSelected.IsChecked == true && secondSelected.IsChecked == false && thirdSelected.IsChecked == true)
            {
                var rational1 = new Rational(pair1.First, pair1.Second);
                var rational3 = new Rational(pair3.First, pair3.Second);
                result = rational1 - rational3; // Используем переопределенную операцию вычитания из Rational
            }
            else if (firstSelected.IsChecked == false && secondSelected.IsChecked == true && thirdSelected.IsChecked == true)
            {
                var rational2 = new Rational(pair2.First, pair2.Second);
                var rational3 = new Rational(pair3.First, pair3.Second);
                result = rational2 - rational3; // Используем переопределенную операцию вычитания из Rational
            }
            else if (firstSelected.IsChecked == true && secondSelected.IsChecked == true && thirdSelected.IsChecked == true)
            {
                var rational1 = new Rational(pair1.First, pair1.Second);
                var rational2 = new Rational(pair2.First, pair2.Second);
                var rational3 = new Rational(pair3.First, pair3.Second);
                result = rational1 - rational2 - rational3; // Вычисление результата через вычитание с использованием Rational
            }

            // Конвертировать результат в строку
            if (result != null)
            {
                resultMinus.Text = $"{result.First} / {result.Second}";
            }
        }

        /// <summary>
        /// Событие "Перемножить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            firsrtPair1.Text = pair1.First.ToString();
            firsrtPair2.Text = pair1.Second.ToString();
            secondPair1.Text = pair2.First.ToString();
            secondPair2.Text = pair2.Second.ToString();
            thirdPair1.Text = pair3.First.ToString();
            thirdPair2.Text = pair3.Second.ToString();

            //проверяется состояние флажков
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == false && thirdSelected.IsChecked == false)
            {
                resultMultiply.Text = Convert.ToString(pair1.Multiply());
            }
            if (firstSelected.IsChecked == false && secondSelected.IsChecked == true && thirdSelected.IsChecked == false)
            {
                resultMultiply.Text = Convert.ToString(pair2.Multiply());
            }
            if (firstSelected.IsChecked == false && secondSelected.IsChecked == false && thirdSelected.IsChecked == true)
            {
                resultMultiply.Text = Convert.ToString(pair3.Multiply());
            }
            // resultMultiply содержит результат умножения 
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == true && thirdSelected.IsChecked == false)
            {
                Pair result = pair1.Multiply(pair2);
                resultMultiply.Text = Convert.ToString(result.First + " , " + result.Second);
            }
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == false && thirdSelected.IsChecked == true)
            {
                Pair result = pair1.Multiply(pair3);
                resultMultiply.Text = Convert.ToString(result.First + " , " + result.Second);
            }
            if (firstSelected.IsChecked == false && secondSelected.IsChecked == true && thirdSelected.IsChecked == true)
            {
                Pair result = pair2.Multiply(pair3);
                resultMultiply.Text = Convert.ToString(result.First + " , " + result.Second);
            }
            if (firstSelected.IsChecked == true && secondSelected.IsChecked == true && thirdSelected.IsChecked == true)
            {
                Pair result = pair1.Multiply(pair2, pair3);
                resultMultiply.Text = Convert.ToString(result.First + " , " + result.Second);
            }
        }

        /// <summary>
        /// Событие на проверку введённого текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviewTextBoxInput(object sender, TextCompositionEventArgs e)
        {
            // Проверяет, можно ли преобразовать введенный текст в целое число.
            if (!int.TryParse(e.Text, out int addvalue))
            {
                e.Handled = true; // Если преобразование удалось (введен корректный текст), вставляет цифры.
            }
        }

        /// <summary>
        /// Событие изменения текста в текстовом поле
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            // Извлекает имя текстового поля, которое вызвало событие, и обновляет соответствующие поля пары (Pair) с введенными значениями.
            int addValue;
            switch (((TextBox)sender).Name)//определения имени текстового поля (sender), который вызвал событие.
            {
                case "firsrtPair1":
                    // Преобразует текст из поля "firsrtPair1" в целое число и присваивает его первому элементу первой пары (pair1.First).
                    int.TryParse(firsrtPair1.Text, out addValue);
                    pair1.First = addValue;
                    break;
                case "firsrtPair2":
                    // Преобразует текст из поля "firsrtPair2" в целое число и присваивает его второму элементу первой пары (pair1.Second).
                    int.TryParse(firsrtPair2.Text, out addValue);
                    pair1.Second = addValue;
                    break;
                case "secondPair1":
                    int.TryParse(secondPair1.Text, out addValue);
                    pair2.First = addValue;
                    break;
                case "secondPair2":
                    int.TryParse(secondPair2.Text, out addValue);
                    pair2.Second = addValue;
                    break;
                case "thirdPair1":
                    int.TryParse(thirdPair1.Text, out addValue);
                    pair3.First = addValue;
                    break;
                case "thirdPair2":
                    int.TryParse(thirdPair2.Text, out addValue);
                    pair3.Second = addValue;
                    break;
            }
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                rational1 = new Rational(int.Parse(firstRationalNumerator.Text), int.Parse(firstRationalDenominator.Text));
                rational2 = new Rational(int.Parse(secondRationalNumerator.Text), int.Parse(secondRationalDenominator.Text));
                Rational result = rational1.Divide(rational2);
                resultDivide.Text = $"{result.First} / {result.Second}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                rational1 = new Rational(int.Parse(firstRationalNumerator.Text), int.Parse(firstRationalDenominator.Text));
                rational2 = new Rational(int.Parse(secondRationalNumerator.Text), int.Parse(secondRationalDenominator.Text));
                Rational result = rational1.Add(rational2);
                resultAdd.Text = $"{result.First} / {result.Second}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}