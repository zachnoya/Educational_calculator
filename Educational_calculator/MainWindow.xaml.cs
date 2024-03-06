using System;
using System.Windows;
using System.Windows.Media;


namespace Educational_calculator
{
    public partial class MainWindow : Window
    {
        private int num1;
        private int num2;
        private int correctAnswer;
        private int questionsCount = 1;
        private int correctAnswersCount;
        private int incorrectanswerCount;




        public MainWindow()
        {
            InitializeComponent();
            GenerateProblem();
            Loaded += MainWindow_Loaded;
            InitializeComponent();

        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            mediaElement.Play();
            mediaElement.Volume = 1.0;
        }



        private void FirstGradeBtn_Click(object sender, RoutedEventArgs e)
        {
            Buttons.Visibility = Visibility.Collapsed;
            exercise.Visibility = Visibility.Visible;
            StopAudio();

        }

        private void SecondGradeBtn_Click(object sender, RoutedEventArgs e)
        {
            Buttons.Visibility = Visibility.Collapsed;
            exercise.Visibility = Visibility.Visible;
            StopAudio();

        }

        private void ThirdGradeBtn_Click(object sender, RoutedEventArgs e)
        {
            Buttons.Visibility = Visibility.Collapsed;
            exercise.Visibility = Visibility.Visible;
            StopAudio();

        }

        private void FourthGradeBtn_Click(object sender, RoutedEventArgs e)
        {
            Buttons.Visibility = Visibility.Collapsed;
            exercise.Visibility = Visibility.Visible;
            StopAudio();

            int result = SimpleCalculator.GenerateMultiplicationExercise();



        }




        private void GenerateProblem()
        {
            Random random = new Random();
            num1 = random.Next(1, 15);
            num2 = random.Next(1, 15);
            correctAnswer = num1 + num2;

            problemTextBlock.Text = $"{num1} + {num2} = ?";
            resultTextBlock.Text = "";
            answerTextBox.Text = "";
        }

        private void CheckAnswer_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(answerTextBox.Text, out int userAnswer))
            {
                if (userAnswer == correctAnswer)
                {
                    resultTextBlock.Text = "Correct!";
                    correctAnswersCount++;
                    correctSound.Play();
                    correctSound.Volume = 1.0;
                    correctSound.Visibility = Visibility.Visible;
                    YourMediaElement.Play();
                }
                else
                {
                    resultTextBlock.Text = "Incorrect. Try again.";
                    incorrectanswerCount++;
                    erorSound.Play();
                    erorSound.Volume = 1.0;
                    erorSound.Visibility = Visibility.Collapsed;
                    YourMediaElement2.Play();
                }
            }
            else
            {
                resultTextBlock.Text = "Please enter a valid number.";
            }
        }

        private void NextProblem_Click(object sender, RoutedEventArgs e)
        {
            GenerateProblem();
        }

        private void StopAudio()
        {
            mediaElement.Stop();

        }

        private void GenerateProblemButton_Click(object sender, RoutedEventArgs e)
        {
            GenerateProblem();
            questionsCount++;

            YourMediaElement.Visibility = Visibility.Collapsed;
            YourMediaElement.Visibility = Visibility.Visible;
            YourMediaElement.Close();
            YourMediaElement2.Visibility = Visibility.Collapsed;
            YourMediaElement2.Visibility = Visibility.Visible;
            YourMediaElement2.Close();
        }

        private void GetGrade()
        {
            Grade.Text = ($"You solved {questionsCount} questions, {correctAnswersCount} of them are correct, and {incorrectanswerCount} of them are incorrect");
            int grade = (int)Math.Round(((double)correctAnswersCount / questionsCount) * 100);

            GradePercentage.Text = ($"                                    Your success percentage is: {grade}%");
            mediaElement.Stop();
            mediaElement.Position = TimeSpan.Zero;
            YourMediaElement.Visibility = Visibility.Collapsed;
            YourMediaElement2.Visibility = Visibility.Collapsed;

        }


        private void Grade_Click(object sender, RoutedEventArgs e)
        {
            GetGrade();
        }


    }
}
