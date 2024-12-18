using System;
using System.Windows.Forms;

namespace quiz_game
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            askQuestion(questionNumber);
            totalQuestions = 8;
        }
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                percentage = (score * 100) / totalQuestions;

                DialogResult result = MessageBox.Show(
                    caption: "GAME ENDED!",
                    text: $"Your final score is: {score}/{totalQuestions} \nYour percentage: {percentage}%\nPress Yes to play again, No to exit.",
                    buttons: MessageBoxButtons.YesNo,
                    icon: MessageBoxIcon.Information
                );

                if (result == DialogResult.Yes)
                {
                    score = 0;
                    questionNumber = 1;
                    askQuestion(questionNumber);
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                questionNumber++;
                askQuestion(questionNumber);
            }
        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.question2;
                    lblQuestion.Text = "Melyik évben jelent meg az első PlayStation konzol?";
                    button1.Text = "1992";
                    button2.Text = "1994";
                    button3.Text = "1996";
                    button4.Text = "1998";
                    correctAnswer = 2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.question2;
                    lblQuestion.Text = "Melyik játékban kell portálokat használni a rejtvények megoldására?";
                    button1.Text = "Half-Life";
                    button2.Text = "Portal";
                    button3.Text = "Prey";
                    button4.Text = "Dishonored";
                    correctAnswer = 2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.enderdragon;
                    lblQuestion.Text = "Melyik játékban található az “Ender Dragon”?";
                    button1.Text = "Skyrim";
                    button2.Text = "Minecraft";
                    button3.Text = "Dragon Age";
                    button4.Text = "World of Warcraft";
                    correctAnswer = 2;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Csgo_dust2;
                    lblQuestion.Text = "Melyik játékban van a “Dust II” pálya?";
                    button1.Text = "Rainbow Six Siege";
                    button2.Text = "Apex Legends";
                    button3.Text = "Counter-Strike";
                    button4.Text = "PUBG";
                    correctAnswer = 3;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.majula;
                    lblQuestion.Text = "Melyik játékban található a “Majula” nevű helyszín?";
                    button1.Text = "Dark Souls II";
                    button2.Text = "Bloodborne";
                    button3.Text = "Elden Ring";
                    button4.Text = "Sekiro";
                    correctAnswer = 1;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.witcher;
                    lblQuestion.Text = "Mi a neve a Witcher játékok főszereplőjének?";
                    button1.Text = "Geralt of Rivia";
                    button2.Text = "Ezio Auditore";
                    button3.Text = "Arthur Morgan";
                    button4.Text = "Galbács Bence";
                    correctAnswer = 1;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.tetris;
                    lblQuestion.Text = "Mi a cél a Tetris játékban?";
                    button1.Text = "A kockák eltüntetése sorok kialakításával";
                    button2.Text = "Ellenfelek legyőzése";
                    button3.Text = "Rejtett tárgyak keresése";
                    button4.Text = "Akadályok átugrása";
                    correctAnswer = 1;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.question2;
                    lblQuestion.Text = "Mi történik, ha túl gyorsan építesz egy házat a Minecraft-ban?";
                    button1.Text = "Elindul az “építész rendőrség”";
                    button2.Text = "A Creeper beköltözik és megöl";
                    button3.Text = "Az ajtó fejjel lefelé lesz";
                    button4.Text = "A macska már a tetőn vár rád";
                    correctAnswer = 2;
                    break;
            }
        }
    }
}
