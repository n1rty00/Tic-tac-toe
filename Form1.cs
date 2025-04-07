using System.Diagnostics;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        private int player;
        private bool isGameOver;

        public Form1()
        {
            InitializeComponent();
            player = 1;
            label1.Text = "“екущий ход,игрок 1";
        }
        private Random random = new Random();
        private void button10_Click_1(object sender, EventArgs e)
        {
            buttonAI.Text = "OK"; //это € так включаю кнопки(€ художник, € так вижу) 
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            friends.Enabled = false;
            buttonAI.Enabled = false;


        }
        private void button11_Click(object sender, EventArgs e)
        {
            friends.Text = "OK"; //здесь тоже самое, только дл€ другой кнопочке
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            buttonAI.Enabled = false;
            friends.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (isGameOver) return;

            if (buttonAI.Text == "OK") //здесь € самым ущербным способом сделал выбор как хочетс€ играть
            {
            player:
                switch (player)
                {
                    case 1:
                        sender.GetType().GetProperty("Text").SetValue(sender, "x"); // это типо х ходит
                        sender.GetType().GetProperty("Enabled").SetValue(sender, false);
                        player = 0;
                        label1.Text = "“екущий ход,игрок 2";
                        chekwin();
                        if (!isGameOver)
                        {
                            Thread.Sleep(300);
                            goto player;
                        }
                        break;
                    case 0:
                        int attempts = 0; //а вот это фиговина котора€ €кобы искуственный интелект
                    Select:
                        if (attempts == 100)
                        {
                            break;
                        }
                        attempts++;
                        var index = random.Next(9);

                        if (index == 0)
                        {

                            if (button1.Enabled == true)
                            {
                                button1.Text = "o";
                                button1.Enabled = false;
                            }
                            else
                            {
                                goto Select;
                            }
                        }
                        if (index == 1)
                        {
                            if (button2.Enabled == true)
                            {
                                button2.Text = "o";
                                button2.Enabled = false;
                            }
                            else { goto Select; }
                        }
                        if (index == 2)
                        {
                            if (button3.Enabled == true)
                            {
                                button3.Text = "o";
                                button3.Enabled = false;
                            }
                            else { goto Select; }
                        }
                        if (index == 3)
                        {
                            if (button4.Enabled == true)
                            {
                                button4.Text = "o";
                                button4.Enabled = false;
                            }
                            else { goto Select; }
                        }
                        if (index == 4)
                        {
                            if (button5.Enabled == true)
                            {
                                button5.Text = "o";
                                button5.Enabled = false;
                            }
                            else { goto Select; }
                        }
                        if (index == 5)
                        {
                            if (button6.Enabled == true)
                            {
                                button6.Text = "o";
                                button6.Enabled = false;
                            }
                            else { goto Select; }
                        }
                        if (index == 6)
                        {
                            if (button7.Enabled == true)
                            {
                                button7.Text = "o";
                                button7.Enabled = false;
                            }
                            else { goto Select; }
                        }
                        if (index == 7)
                        {
                            if (button8.Enabled == true)
                            {
                                button8.Text = "o";
                                button8.Enabled = false;
                            }
                            else { goto Select; }
                        }
                        if (index == 8)
                        {
                            if (button9.Enabled == true)
                            {
                                button9.Text = "o";
                                button9.Enabled = false;
                            }
                            else { goto Select; }
                        }
                        player = 1;
                        label1.Text = "“екущий ход,игрок 1";
                        chekwin();
                        break;
                }
            }
            if (friends.Text == "OK") // типо режим с друзь€ми(сделаный самым ущербным способом)
            {
            player:
                switch (player)
                {
                    case 1:
                        sender.GetType().GetProperty("Text").SetValue(sender, "x"); // 1 игрок
                        sender.GetType().GetProperty("Enabled").SetValue(sender, false);
                        player = 0;
                        label1.Text = "“екущий ход,игрок 2";
                        break;

                    case 0:
                        sender.GetType().GetProperty("Text").SetValue(sender, "o"); // 2 игрок
                        sender.GetType().GetProperty("Enabled").SetValue(sender, false);
                        player = 1;
                        label1.Text = "“екущий ход,игрок 1";
                        break;
                }

                chekwin();
            }
        }
        private void chekwin()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "") // эта при каких услови€х будет гаме овер
            {
                gameOver(button1.Text);
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
                gameOver(button4.Text);
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
                gameOver(button7.Text);
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
                gameOver(button1.Text);
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
                gameOver(button2.Text);
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
                gameOver(button3.Text);
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
                gameOver(button1.Text);
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
                gameOver(button3.Text);
            if (button1.Text == "" || button2.Text == "" || button3.Text == "" || button4.Text == "" || button5.Text == "" || button6.Text == "" || button7.Text == "" || button8.Text == "" || button9.Text == "")
            {
                return;
            }
            gameOver();
        }

        private void gameOver(string? winner = null) //это более гениальный способ выбора победившего по сравнению с прошлым
        {
            if (winner == null)
            {
                MessageBox.Show("Ќичь€!");
            }
            else
            {
                MessageBox.Show($"»гра окончена! ѕобедил игрок {winner}");
            }

            label1.Text = "Game over";
            isGameOver = true;

            button1.Enabled = false; // кнопочке выключаютс€
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e) //без пон€ти€ нафига оно мне
        {

        }

        private void buttonRestart_Click_1(object sender, EventArgs e) // эта типа рестарт
        {
            Application.Restart();
        }
    }
}