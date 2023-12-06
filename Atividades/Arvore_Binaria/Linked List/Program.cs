using Linked_List;

Pages pageFirst = new Pages(){Content="atualmente..."};
Pages pageSecond= new Pages(){Content="Aplicação..."};
Pages pageThird = new Pages(){Content="Muito de ..."};
Pages pageFourth= new Pages(){Content="Você sabia..."};
Pages pageFifht = new Pages()
{
    Content="Enquanto...",
    PagesNumber=5
};
Pages pageSixth = new Pages(){Content="Você poderia..."};

pageSixth.PagesNumber=6;
var pageSeventh =new Pages();
pageSeventh.Content="era uma vez";
pageSeventh.PagesNumber=7;
LinkedList<Pages> pages=new LinkedList<Pages>();//procedimento
pages.AddLast(pageSecond);
LinkedListNode<Pages> nodePageFouth=pages.AddLast(pageFourth);//função
pages.AddLast(pageSixth);
pages.AddLast(pageFifht);


pages.AddBefore(nodePageFouth,pageThird);
pages.AddAfter(nodePageFouth,pageFifht);
