using System;

public class Book
{
    public int numberOfPages;

    public Book() { }

    public Book(int numberOfPages)
    {
        this.numberOfPages = numberOfPages;
    }


    public int GetNumberOfPages()
    {
        return numberOfPages;
    }

    public void SetNumberOfPages(int NewNumberOfPages)
    {
        numberOfPages = NewNumberOfPages;   
    }
}