
//Task4 url - https://www.exercisescsharp.com/oop/photo-book-class

class PhotoBookTest
{
    static void Main(string[] args)
    {

        PhotoBook photoBook = new PhotoBook();

        photoBook.GetNumberPages();

        PhotoBook photoBook2 = new PhotoBook(24);
        photoBook2.GetNumberPages();

        BigPhotoBook bigPhotoBook = new BigPhotoBook();
        bigPhotoBook.GetNumberPagesOfBigPhotoBook();
    }
}

class PhotoBook
{
    private int numPages;

    public PhotoBook(int numPages)
    {
       this.numPages = numPages;
    }

    public PhotoBook()
    {
        this.numPages = 16;
    }

    public void GetNumberPages()
    {
       Console.WriteLine(numPages);
    }
}

class BigPhotoBook 
{
    private int numPagesBig;
    public BigPhotoBook()
    {

       numPagesBig = 64; 

    }
    public BigPhotoBook(int numPagesBig)
    {
        this.numPagesBig = numPagesBig;
    }

    public void GetNumberPagesOfBigPhotoBook()
    {
        Console.WriteLine(numPagesBig);
    }
}