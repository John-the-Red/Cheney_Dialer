using System;
// First or Nickname Lastname
// IT112
// NOTES: At the start the instructions were hard to follow, but after reviewing your examples I figured it out immediately
// I will be honest in that I need to go back and review some of the past lectures because I feel like I was not understanding some of it fully but know what questions I want to ask
// BEHAVIORS NOT IMPLIMENTED AND WHY: All Behaviors Implemented
namespace Cheney_Dialer
{
    class Program
    {

        static void Main(string[] args)
        {
            Phone[] P = new Phone[10];
            P[0] = new Homephone("Computest", "(303) 985-5060", 1);
            P[1] = new Cellphone("Curtis Manufacturing", "(603) 532-4123", 2);
            P[2] = new Homephone("Data Functions", "(800) 876-2524", 1);
            P[3] = new Homephone("Donnay Repair", "(708) 397-3330", 1);
            P[4] = new Homephone("ErgoNomic Inc", "(360) 434-3894", 1);
            P[5] = new Homephone("ErgoSource", "(800) 969-4374", 1);
            P[6] = new Cellphone("Fox Bay Industries", "(800) 874-8527", 2);
            P[7] = new Cellphone("Glare-Guard", "(800) 545-6254", 2);
            P[8] = new Cellphone("Hazard Comm Specialists", "(407) 783-6641",2);
            P[9] = new Cellphone("Komfort Support", "(714) 472-4409", 2);

            for(int i=0; i < P.Length; i++)
            {
                P[i].Dial();
            }
        }


    }
}
