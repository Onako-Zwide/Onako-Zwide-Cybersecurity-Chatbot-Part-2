# Onako-Zwide-Cybersecurity-Chatbot-Part-2
## Project Overview
Uniqua SafeSpace is a WPF-based cybersecurity awareness chatbot designed to educate users about online safety topics such as phishing, scams, password security, privacy, VPN usage, cyberbullying, social engineering and safe internet practices.
The chatbot provides interactive responses, remembers users, and adapts replies based on sentiment and conversation history.

# My project includes the following files:
- App.xaml
- App.xaml.cs
- AssemblyInfo.cs
- ChatBot.cs  
- KeywordResponder.cs
- MainWindow.xaml  
- MainWindow.xaml.cs
- MemoryStore.cs  
- SentimentDetector.cs
- SplashScreen.xaml
- SplashScreen.xaml.cs

# GUI
I designed a WPF-based graphical user interface for my chatbot.
My interface includes:
-A clean chat bubble system for both user and chatbot messages
-A scrollable chat area to view conversation history
-A typing indicator to simulate real-time responses
-A voice greeting that plays when the application starts
-A splash screen that appears before the main window loads
When the application starts, the splash screen displays before the main chatbot window opens, simulates a loading experience, 3-4 seconds later it closes then the main chatbot window opens automatically and the conversation begins.

# Chatbot.cs
I created the ChatBot.cs file as the core logic of my application. This file controls how the chatbot behaves and responds during conversations.
In this file, I implemented:
Conversation flow control (asking for the user’s name and starting the chat)
Keyword recognition to detect cybersecurity topics such as phishing, scams, and password safety
Sentiment detection to adjust responses based on the user’s emotion
Memory integration to remember user details like name and favourite topics
Follow-up handling using phrases like “tell me more” and “explain more”
Returning user detection to welcome users back with previous context. 
I included multiple cybersecurity awareness topics, such as:
- Phishing 
- Password safety
- Scams
- Online safety
- VPN 
- Privacy
- Cyberbullying
- Email safety
- Social engineering
- Suspicious links


#
I implemented a keyword-based response system that allows the chatbot to recognise user input and respond appropriately.
I also added:
- Randomised responses to make conversations less repetitive
- Follow-up handling using phrases like "tell me more"
- Conversation flow tracking using the last topic discussed
- Personalised greetings for both new and returning users

#
I then created a memory system that:
- Stores the user's name
- Stores their favourite cybersecurity topic
- Remembers returning users using file storage
- Personalises responses based on previous conversations

#
I implemented sentiment detection to identify user emotions such as:
- Worried
- Curious
- Frustrated

# Youtube & Video
-Recorded my presentation video and ran my project on it 
-I uploaded my cybersecurity chatbot presentation video on youtube

# CI tick
<img width="1308" height="268" alt="image" src="https://github.com/user-attachments/assets/57a53efe-e22e-4df9-823d-7a825adcd446" />

- Happy

