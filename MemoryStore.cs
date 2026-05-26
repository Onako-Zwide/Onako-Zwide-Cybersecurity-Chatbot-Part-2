namespace CyberSecurityChatbot_PART_2
{
    // This class stores user information
    // to help the chatbot remember details
    // and personalise conversations.
    public class MemoryStore
    {
        // Stores the user's name
        // entered at the beginning of the chat.
        public string UserName { get; set; }

        // Stores the user's favourite
        // cybersecurity topic.
        public string FavouriteTopic { get; set; }

        // This method saves the topic
        // the user is interested in.
        public void StoreTopic(string topic)
        {
            FavouriteTopic = topic;
        }

        // This method returns a personalised message
        // based on the user's favourite topic.
        public string GetPersonalisedOpener()
        {
            // Checks if a favourite topic exists
            if (!string.IsNullOrEmpty(FavouriteTopic))
            {
                return $"Since you’re interested in {FavouriteTopic}, here’s something useful: ";
            }

            // Returns an empty string
            // if no topic has been stored.
            return "";
        }

        // This method creates a personalised greeting
        // using the user's name.
        public string GetNameGreeting()
        {
            // Checks if the user's name exists
            if (!string.IsNullOrEmpty(UserName))
            {
                return $"Great to see you again, {UserName}! ";
            }

            // Returns nothing if no name exists
            return "";
        }
    }
}