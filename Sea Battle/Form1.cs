using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sea_Battle
{
    public partial class Form1 : Form
    {
        Label label1 = new Label();//нужен чисто для отладки
        List<char> alphabet = new List<char> { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И', 'К' };//список для буквенного обозначения столбцов
        public Form1()
        {
            InitializeComponent();
            MakeBattle(0);//использование метода для создания дружественного поля
            MakeBattle(1);//использование метода для создания поля врага
            
            Controls.Add(label1);//нужен чисто для отладки
            label1.Text = "ничего не нажато";//нужен чисто для отладки
            label1.Size = new Size(500,20);//нужен чисто для отладки
            label1.Location = new Point(0, 0);//нужен чисто для отладки
        }
        public void MakeBattle(int Team) //данный метод нужен для создания поля
        {
           for (int i = 0; i < 10; i++) //цикл для повторения следущего цикла
           {
                for (int j = 0; j < 10; j++) //цикл для создания строки
                    prekol(Team, i, j);//метод создания кнопки
            }
        }

        private void prekol(int Team, int i, int j)//метод создания кнопки
        {
            Button button = new Button(); //создание кнопки
            button.Size = new Size(45, 45); //задание размеров кнопки
            button.Location = new Point(20 + j * 45 + 500 * Team, 20 + i * 45); //задание расположения кнопки
            button.Text = $"{alphabet[j]}{i + 1}"; //задание текста кнопки
            button.Name = $"team{Team}button{alphabet[j]}{i + 1}"; //задание уникального названия кнопки по типу:
                                                                   //"team{номер команды}button{буквенное обозначение столбца}{численное обозначение строки}"
            Controls.Add(button); //добавление кнопки в Controls
            button.Click += new EventHandler(Button_pole_click); //добавление события нажатия по кнопке button_click
        }

        public void Button_pole_click(object sender, EventArgs e) //событие нажатия по кнопке поля пока не придумал как должно быть взаимодействие
        {
            List<char> list = new List<char>((((Button)sender).Text).ToCharArray()); //переводит уникальное название кнопки в список символов


            /*if (list[4] != '0') //проверка на команду кнопки поля                       тут вызывается ошибка по поводу слишком большого индекса списка поэтому
                                                                                            //я его закомментирую и добавлю label для отладки
            {
                return;
            }
            for (int i = 0; i < 10; i++)
            {
                if (list[11] == alphabet[i]) { }
            }*/



        }
    }
}
