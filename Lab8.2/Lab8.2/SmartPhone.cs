using System;


namespace PhoneEvolution
{
    class SmartPhone : AllColorPhone
    {
        public int Cameras { get; set; }
        public int MaxTouchAbility { get; set; }
        public bool TouchAbility { get; set; }

        public SmartPhone(int maxTouchAbility, int camerasNum, string PhoneNum, int screenW, int screenH, double screen_size, string phone_color, int screen_colors_q, string another_phone_num = null) : base(PhoneNum, screenW, screenH, screen_size, phone_color, screen_colors_q, another_phone_num)
        {
            Cameras = camerasNum;
            MaxTouchAbility = maxTouchAbility;

            if (MaxTouchAbility > 0) TouchAbility = true;
        }

        public void MakeWiew()
        {
            if (Cameras == 1) Console.WriteLine("You took a photo/video with a regular camera");

            else if (Cameras > 1)
            {
                int chooseCamera;
                Console.WriteLine($"Which camera do you want to take a photo/video with? (you have everything {Cameras}):");
                while (!int.TryParse(Console.ReadLine(), out chooseCamera) || chooseCamera < 1 || chooseCamera > Cameras)
                {
                    Console.WriteLine($"Everything on the phone {Cameras}! Choose one of them:");
                }
                Console.WriteLine($"You took a photo/video on {chooseCamera}");
            }

            else Console.WriteLine("No cameras found on the phone!");
        }
    }
}