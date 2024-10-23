
static void tao_game()
{
    // may nghi ngau nhien mot so
    Random rnd = new Random();
    int comp_num = rnd.Next(0,100)+1;
    // hoi nguoi dung doan so 
    // doan den khi nao dung thi thoi
    int count = 0;
    bool iscountinue = true;
    do
    {
        count++;
        Console.Write("ban doan so may? <1...100>");
        int user_num = int.Parse(Console.ReadLine());
        ///3.kiem tra ket qua
        if (user_num == comp_num)
        {
            Console.WriteLine("ban doan dung sau {count} lan");
            iscountinue = false;

        }
        else
        {
            if (user_num > comp_num)
                Console.WriteLine("so ban doan lon hon so may nghi");
            else
                Console.WriteLine("so ban doan nho hon so may nghi");
        }
    } while (iscountinue);

    Console.WriteLine(" choi nua khong?<C/K>:");
    string tl = Console.ReadLine();
    if (tl.ToUpper().Equals("k"))
    {
        Console.WriteLine("tam biet");
        return;
    }
    
}while (true) ;
