using System.Diagnostics;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        private int player;
        public Form1()
        {
            InitializeComponent();
            player = 1;
            label1.Text = "Текущий ход,игрок 1";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "x");
                    sender.GetType().GetProperty("Enabled").SetValue(sender, false);
                    player = 0;
                    label1.Text = "Текущий ход,игрок 2";
                    break;
                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "o");
                    sender.GetType().GetProperty("Enabled").SetValue(sender, false);
                    player = 1;
                    label1.Text = "Текущий ход,игрок 1";
                    break;
            }
            chekwin();
        }
        private void chekwin()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show("Игра окончена! Победил игрок: " + button1.Text);
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text != "")
                    MessageBox.Show("Игра окончена! Победил игрок: " + button4.Text);
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text != "")
                    MessageBox.Show("Игра окончена! Победил игрок: " + button7.Text);
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show("Игра окончена! Победил игрок: " + button1.Text);
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text != "")
                    MessageBox.Show("Игра окончена! Победил игрок: " + button2.Text);
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text != "")
                    MessageBox.Show("Игра окончена! Победил игрок: " + button3.Text);
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show("Игра окончена! Победил игрок: " + button1.Text);
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text != "")
                    MessageBox.Show("Игра окончена! Победил игрок: " + button3.Text);
            }
            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("Ничья!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void buttonRestart_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}