using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PathfinderCharGen.Commands.Specific;
using ReactiveLeveling.Pathfinder;
using PathfinderCharGen.Networking;

namespace PathfinderCharGen.ViewModels
{
    class ChatUIViewModel : ViewModelBase
    {

        public ChatUIViewModel()
        {
            MessageTypes.Add("Chat");
            MessageTypes.Add("Whisper");
            MessageTypes.Add("Language");
            MessageTypes.Add("Command");
            MessageTypes.Add("Other");

            MessageContexts.Add("ChatContext1");
            MessageContexts.Add("ChatContext2");
            MessageContexts.Add("WhisperContext1");
            MessageContexts.Add("WhisperContext2");
            MessageContexts.Add("etc");
        }

        private string Message;
        private string ChatLog;


        private List<string> MessageTypes = new List<string>();
        private List<string> MessageContexts = new List<string>();

        private SendCommand sendCmd;
        private ClearCommand clearCmd;

        #region Properties

        public string MSG_Type1
        {
            get { return MessageTypes[0]; }
            set
            {
                MessageTypes[0] = value;
                OnPropertyChanged("MSG_Type1");
            }
        }

        public string MSG_Type2
        {
            get { return MessageTypes[1]; }
            set
            {
                MessageTypes[1] = value;
                OnPropertyChanged("MSG_Type2");
            }
        }

        public string MSG_Type3
        {
            get { return MessageTypes[2]; }
            set
            {
                MessageTypes[2] = value;
                OnPropertyChanged("MSG_Type3");
            }
        }

        public string MSG_Type4
        {
            get { return MessageTypes[3]; }
            set
            {
                MessageTypes[3] = value;
                OnPropertyChanged("MSG_Type4");
            }
        }

        public string MSG_Type5
        {
            get { return MessageTypes[4]; }
            set
            {
                MessageTypes[4] = value;
                OnPropertyChanged("MSG_Type5");
            }
        }

        public string MSG_Context1
        {
            get { return MessageContexts[0]; }
            set
            {
                MessageContexts[0] = value;
                OnPropertyChanged("MSG_Context1");
            }
        }

        public string MSG_Context2
        {
            get { return MessageContexts[1]; }
            set
            {
                MessageContexts[1] = value;
                OnPropertyChanged("MSG_Context2");
            }
        }

        public string MSG_Context3
        {
            get { return MessageContexts[2]; }
            set
            {
                MessageContexts[2] = value;
                OnPropertyChanged("MSG_Context3");
            }
        }

        public string MSG_Context4
        {
            get { return MessageContexts[3]; }
            set
            {
                MessageContexts[3] = value;
                OnPropertyChanged("MSG_Context4");
            }
        }

        public string MSG_Context5
        {
            get { return MessageContexts[4]; }
            set
            {
                MessageContexts[4] = value;
                OnPropertyChanged("MSG_Context5");
            }
        }


        public string test
        {
            get
            {
                return Message;
            }
            set
            {
                Message = value;
                OnPropertyChanged("Nothing");

            }
        }
        

        public string MSG
        {
            get
            {
                return Message;
            }
            set
            {
                Message = value;
                OnPropertyChanged("MSG");             
            }
        }
      
        #endregion


        public ICommand SendMessage
        {
            get
            {
                return sendCmd;
            }
        }

        public ICommand ClearMessage
        {
            get
            {
                return clearCmd;
            }
        }




    }
}
