using System;
public class Node
{
    public string NamaMenu;
    public int Kuantitas;
    public Node? Next;

    public Node(string data, int kuantitas)
    {
        NamaMenu = data;
        Kuantitas = kuantitas;
        Next = null;
    }
}


public class ListMenu
{
    private Node? head;

    public void TambahMenu(string menu, int kuantitas)
    {
        Node newNode = new Node(menu, kuantitas);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }
    public void HapusMenuPadaIndex(int index)
    {
        if (index == 1)
        {
            head = head.Next;
            return;
        }

        Node current = head;
        int posisi = 1;

        while (current != null && posisi < index - 1)
        {
            current = current.Next;
            posisi++;
        }

        current.Next = current.Next.Next;
    }


    public void TampilkanMenu()
    {
        if (head == null)
        {
            return;
        }

        Node current = head;
        while (current != null)
        {
            Console.WriteLine($"- {current.NamaMenu} {current.Kuantitas} pcs");
            current = current.Next;
        }
    }
    public void TampilkanMenuNomor()
    {
        if (head == null)
        {
            return;
        }

        Node current = head;
        int nomor = 1;
        while (current != null)
        {
            Console.WriteLine($"{nomor}. {current.NamaMenu} {current.Kuantitas} pcs");
            current = current.Next;
            nomor++;
        }
    }
}
