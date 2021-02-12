using System;

namespace OPTIONALCONSOLEPROJECT
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;
            bool zeroornot = true;
        EnterOptionCorrectly:
            do
            {
                Console.WriteLine("========================");
                Console.WriteLine("-1 Menu uzerinde emeliyyat aparmaq");
                Console.WriteLine("-2 Sifarisler uzerinde emeliyyat aparmaq");
                Console.WriteLine("-0 Sistemden cixmaq");
                option = Console.ReadLine();
                option = option.Trim();
                switch (option)
                {
                    case ("1"):
                        string option1;

                    EnterOption1Correctly:
                        Console.WriteLine("========================");
                        Console.WriteLine("- 1 Yeni item elave et");
                        Console.WriteLine("- 2 Item uzerinde duzelis et");
                        Console.WriteLine("- 3 Item sil");
                        Console.WriteLine("- 4 Butun Item-lari goster");
                        Console.WriteLine("- 5 Categoriyasina gore menu item-lari goster");
                        Console.WriteLine("- 6 Qiymet araligina gore menu item-lar goster");
                        Console.WriteLine("- 7 Menu item-lar arasinda ada gore axtaris et (search)");
                        Console.WriteLine("- 0 Evveli menuya qayit");
                        option1 = Console.ReadLine();
                        option1 = option1.Trim();
                        switch (option1)
                        {
                            case ("1"):
                                Console.WriteLine("- 1 Yeni item elave et");
                                break;
                            case ("2"):
                                Console.WriteLine("- 2 Item uzerinde duzelis et");
                                break;
                            case ("3"):
                                Console.WriteLine("- 3 Item sil");
                                break;
                            case ("4"):
                                Console.WriteLine("- 4 Butun Item-lari goster");
                                break;
                            case ("5"):
                                Console.WriteLine("- 5 Categoriyasina gore menu item-lari goster");
                                break;
                            case ("6"):
                                Console.WriteLine("- 6 Qiymet araligina gore menu item-lar goster");
                                break;
                            case ("7"):
                                Console.WriteLine("- 7 Menu item-lar arasinda ada gore axtaris et (search)");
                                break;
                            case ("0"):
                                goto EnterOptionCorrectly;
                            default:
                                goto EnterOption1Correctly;

                        }
                        break;

                    case ("2"):
                        string option2;

                    EnterOption2Correctly:
                        Console.WriteLine("========================");
                        Console.WriteLine("- 1 Yeni sifaris elave etmek");
                        Console.WriteLine("- 2 Sifarisin legvi");
                        Console.WriteLine("- 3 Butun sifarislerin ekrana cixarilmasi");
                        Console.WriteLine("- 4 Verilen tarix araligina gore sifarislrein gosterilmesi ");
                        Console.WriteLine("- 5 Verilen mebleg araligina gore sifarislerin gosterilmesi");
                        Console.WriteLine("- 6 Verilmis bir tarixde olan sifarislerin gosterilmesi");
                        Console.WriteLine("- 7 Verilmis nomreye esasen hemin nomreli sifarisin melumatlarinin gosterilmesi");
                        Console.WriteLine("- 0 Evveli menuya qayit");
                        option1 = Console.ReadLine();
                        option1 = option1.Trim();
                        switch (option1)
                        {
                            case ("1"):
                                Console.WriteLine("- 1 Yeni sifaris elave etmek");
                                break;
                            case ("2"):
                                Console.WriteLine("- 2 Sifarisin legvi");
                                break;
                            case ("3"):
                                Console.WriteLine("- 3 Butun sifarislerin ekrana cixarilmasi");
                                break;
                            case ("4"):
                                Console.WriteLine("- 4 Verilen tarix araligina gore sifarislrein gosterilmesi ");
                                break;
                            case ("5"):
                                Console.WriteLine("- 5 Verilen mebleg araligina gore sifarislerin gosterilmesi");
                                break;
                            case ("6"):
                                Console.WriteLine("- 6 Verilmis bir tarixde olan sifarislerin gosterilmesi");
                                break;
                            case ("7"):
                                Console.WriteLine("- 7 Verilmis nomreye esasen hemin nomreli sifarisin melumatlarinin gosterilmesi");
                                break;
                            case ("0"):
                                goto EnterOptionCorrectly;
                            default:
                                goto EnterOption2Correctly;

                        }
                        break;
                    case ("0"):
                        zeroornot = false;
                        break;
                    default:
                        goto EnterOptionCorrectly;
                }
            } while (zeroornot);


        }
    }
}
