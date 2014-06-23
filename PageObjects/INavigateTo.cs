namespace mstest_sample.PageObjects
{
    public interface INavigateTo<T>
        where T : PageObject
    {
        void NavigateTo();
    }
}