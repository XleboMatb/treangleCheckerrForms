using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treangleCheckerrForms
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void buttonCheckTreangle_Click(object sender, EventArgs e)
        {
            CheckInputValues();
        }

        void CheckInputValues()
        {
            double finalAnswerOne, finalAnswerTwo, finalAnswerThree;

            while (true)
            {
                if (double.TryParse(tbSideOne.Text.ToString(), out finalAnswerOne) & double.TryParse(tbSideTwo.Text.ToString(), out finalAnswerTwo) & double.TryParse(tbSideThree.Text.ToString(), out finalAnswerThree))
                {
                    placeAll(finalAnswerOne, finalAnswerTwo, finalAnswerThree);
                    break;
                }
                if (double.TryParse(tbSideOne.Text.ToString(), out finalAnswerOne) & double.TryParse(tbSideTwo.Text.ToString(), out finalAnswerTwo) & tbSideThree.Text == string.Empty)
                {
                    finalAnswerThree = ThirdSide(finalAnswerOne, finalAnswerTwo);
                    break;
                }
                if (double.TryParse(tbSideTwo.Text.ToString(), out finalAnswerTwo) & double.TryParse(tbSideThree.Text.ToString(), out finalAnswerThree) & tbSideOne.Text == string.Empty)
                {
                    finalAnswerOne = ThirdSide(finalAnswerTwo, finalAnswerThree);
                    break;
                }
                if (double.TryParse(tbSideOne.Text.ToString(), out finalAnswerOne) & double.TryParse(tbSideThree.Text.ToString(), out finalAnswerThree) & tbSideTwo.Text == string.Empty)
                {
                    finalAnswerTwo = ThirdSide(finalAnswerThree, finalAnswerOne);
                    break;
                }
                if (tbSideOne.Text == string.Empty & tbSideTwo.Text == string.Empty || tbSideOne.Text == string.Empty & tbSideThree.Text == string.Empty || tbSideThree.Text == string.Empty & tbSideTwo.Text == string.Empty)
                {
                    MessageBox.Show("Введите значения во все поля!");
                    return;
                }
                else
                {
                    MessageBox.Show("что-то пошло не так! Попробуйте ещё раз!");
                    return;
                }
            }
           
            placeAll(finalAnswerOne, finalAnswerTwo, finalAnswerThree);
            finalResult(finalAnswerOne, finalAnswerTwo, finalAnswerThree);

        }
        string finalResult(double a, double b, double c)
        {
            if (a + b <= c | a + c <= b | b + c <= a)
            {
                return answerLabel.Text = "Данного треугольника не существует";
            }
            else
            {
                if (a == b & b == c)
                {
                    treanglePB.Image = Properties.Resources.ravnostor;
                    treanglePB.SizeMode = PictureBoxSizeMode.StretchImage;
                    return answerLabel.Text = "Равносторонний";

                }
                if (a == b & b != c || a == c & a != b || b == c & c != a)
                {
                    treanglePB.Image = Properties.Resources.ravnobedr;
                    treanglePB.SizeMode = PictureBoxSizeMode.StretchImage;
                    return answerLabel.Text = "Равнобедренный";
                }
                else
                {
                    treanglePB.Image = Properties.Resources.raznostor;
                    treanglePB.SizeMode = PictureBoxSizeMode.StretchImage;
                    return answerLabel.Text = "Разносторонний";
                }
            }
        }
        double ThirdSide(double a, double b)
        {
            double c;
            c = (a * a) + (b * b);
            return Math.Sqrt(c);

        }
        void placeAll(double finalAnswerOne, double finalAnswerTwo, double finalAnswerThree)
        {
            tbSideOne.Text = finalAnswerOne.ToString();
            tbSideTwo.Text = finalAnswerTwo.ToString();
            tbSideThree.Text = finalAnswerThree.ToString();
        }

    }
}
