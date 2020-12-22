using System;


namespace PhoneEvolution
{
    class AllColorPhone : NegColorPhone
    {
        public bool Twin_sim { get; set; }
        public int Screen_colors_q { get; set; }
        public string Another_phone_num { get; set; }

        public AllColorPhone(string PhoneNum, int screenW, int screenH, double screen_size, string phone_color, int screen_colors_q, string another_phone_num = null) : base(PhoneNum, screenW, screenH, screen_size, phone_color)
        {
            Another_phone_num = another_phone_num;
            Screen_colors_q = screen_colors_q;

            if (Another_phone_num != null) Twin_sim = true;
        }

        public virtual void Accept_mms(string senderPhoneNumber)
        {
            Console.WriteLine($"Incoming MMS message from {senderPhoneNumber}");
        }

        public override void Message()
        {
            if (!Twin_sim) base.Message();

            else
            {
                int choose_sim_card;
                Console.Write("Send message from (1 or 2) sim card:");
                while (!int.TryParse(Console.ReadLine(), out choose_sim_card) || choose_sim_card < 1 || choose_sim_card > 2)
                {
                    Console.WriteLine("Incorrect value, try again:");
                }
                Console.WriteLine($"SMS message sent from number: {(choose_sim_card == 1 ? PhoneNumber : Another_phone_num)}to the number: {EnterNumber()}");
            }
        }
        public virtual void Message_MMS()
        {
            if (!Twin_sim) Console.WriteLine($"You have sent MMS to the number: {EnterNumber()}");

            else
            {
                int choose_sim_card;
                Console.Write("Send MMS message from (1 or 2) sim card: ");

                while (!int.TryParse(Console.ReadLine(), out choose_sim_card) || choose_sim_card < 1 || choose_sim_card > 2)
                {
                    Console.WriteLine("Incorrect value, try again:");
                }

                Console.WriteLine($"MMS message sent from the number {(choose_sim_card == 1 ? PhoneNumber : Another_phone_num)} to the number: {EnterNumber()}");
            }
        }

        public override void Call()
        {
            if (!Twin_sim) base.Call();

            else
            {
                int choose_sim_card;
                Console.Write("Make a call from (1 or 2) sim card: ");
                while (!int.TryParse(Console.ReadLine(), out choose_sim_card) || choose_sim_card < 1 || choose_sim_card > 2)
                {
                    Console.WriteLine("Incorrect value, try again: ");
                }

                Console.WriteLine($"You called from the number: {(choose_sim_card == 1 ? PhoneNumber : Another_phone_num)} to the number: {EnterNumber()}");
            }
        }
    }
}