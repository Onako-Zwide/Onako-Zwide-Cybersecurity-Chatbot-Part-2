using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CyberSecurityChatbot_PART_2
{
    // This is the main window of the chatbot application.
    // It controls the chatbot interface and handles user interaction.
    public partial class MainWindow : Window
    {
        // Creates an object of the ChatBot class
        // so that we can access chatbot responses.
        private ChatBot _chatBot;

        // Constructor for MainWindow
        // This runs automatically when the window opens.
        public MainWindow()
        {
            // Loads everything designed in MainWindow.xaml
            InitializeComponent();

            // Creates a new chatbot object
            _chatBot = new ChatBot();

            // Voice greeting
            // This tries to play the chatbot greeting audio
            // when the application starts.
            try
            {
                SoundPlayer player = new SoundPlayer("Chatbot Audio WAV.wav");
                player.Play();
            }
            catch
            {
                // If the audio file cannot be found or played,
                // a message box appears instead of crashing the app.
                MessageBox.Show("Voice greeting could not be played.");
            }

            // Displays the chatbot's first greeting message
            // when the app opens.
            AppendBotMessage(_chatBot.GetGreeting());
        }

        // This method runs when the Send button is clicked.
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            SendMessage();
        }

        // This method allows the user to press Enter
        // on the keyboard instead of clicking Send.
        private void UserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SendMessage();
            }
        }

        // This method handles sending messages
        // between the user and the chatbot.
        private async void SendMessage()
        {
            // Stores what the user typed into a variable
            string input = UserInput.Text;

            // Prevents empty messages from being sent
            if (string.IsNullOrWhiteSpace(input))
                return;

            // Shows the user's message in the chat area
            AppendUserMessage(input);

            // Clears the textbox after sending the message
            UserInput.Clear();

            // Creates a typing indicator bubble
            // to make the chatbot feel more realistic.
            Border typingBubble = new Border
            {
                Background = System.Windows.Media.Brushes.DarkSlateBlue,
                CornerRadius = new CornerRadius(15),
                Padding = new Thickness(10),
                Margin = new Thickness(0, 5, 100, 5),
                HorizontalAlignment = HorizontalAlignment.Left,
                MaxWidth = 150
            };

            // Displays text to show that
            // the chatbot is preparing a response.
            TextBlock typingText = new TextBlock
            {
                Text = "Uniqua is typing...",
                Foreground = System.Windows.Media.Brushes.White
            };

            // Adds the typing bubble to the chat panel
            typingBubble.Child = typingText;
            ChatPanel.Children.Add(typingBubble);

            // Automatically scrolls to the newest message
            ChatScroll.ScrollToEnd();

            // Creates a short delay to simulate
            // the chatbot typing a response.
            await System.Threading.Tasks.Task.Delay(1200);

            // Removes the typing indicator
            // after the delay ends.
            ChatPanel.Children.Remove(typingBubble);

            // Sends the user's message to the chatbot
            // and stores the chatbot response.
            string response = _chatBot.ProcessInput(input);

            // Displays the chatbot response in the chat area.
            AppendBotMessage(response);
        }

        // This method creates and displays
        // the user's message bubble on the right side.
        private void AppendUserMessage(string message)
        {
            // Creates the message bubble design
            Border userBubble = new Border
            {
                Background = System.Windows.Media.Brushes.Magenta,
                CornerRadius = new CornerRadius(15),
                Padding = new Thickness(10),
                Margin = new Thickness(100, 5, 0, 5),
                HorizontalAlignment = HorizontalAlignment.Right,
                MaxWidth = 280
            };

            // Creates the text inside the message bubble
            TextBlock text = new TextBlock
            {
                Text = message,
                Foreground = System.Windows.Media.Brushes.White,
                TextWrapping = TextWrapping.Wrap
            };

            // Adds text into the message bubble
            userBubble.Child = text;

            // Adds the bubble to the chat panel
            ChatPanel.Children.Add(userBubble);

            // Scrolls automatically to newest message
            ChatScroll.ScrollToEnd();
        }

        // This method creates and displays
        // the chatbot's message bubble on the left side.
        private void AppendBotMessage(string message)
        {
            // Creates the chatbot bubble design
            Border botBubble = new Border
            {
                Background = System.Windows.Media.Brushes.DarkSlateBlue,
                CornerRadius = new CornerRadius(15),
                Padding = new Thickness(10),
                Margin = new Thickness(0, 5, 100, 5),
                HorizontalAlignment = HorizontalAlignment.Left,
                MaxWidth = 280
            };

            // Creates the chatbot message text
            TextBlock text = new TextBlock
            {
                // Adds "Uniqua:" before every chatbot message
                Text = "Uniqua: " + message,
                Foreground = System.Windows.Media.Brushes.White,
                TextWrapping = TextWrapping.Wrap
            };

            // Adds text into the chatbot bubble
            botBubble.Child = text;

            // Adds the chatbot bubble to the chat panel
            ChatPanel.Children.Add(botBubble);

            // Scrolls automatically to newest message
            ChatScroll.ScrollToEnd();
        }
    }
}