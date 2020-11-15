namespace OurMoneyBlazor.Shared
{
    public enum EntityTypes
    {
        Categories = 1,
        Sources,
        Accounts,
        Debts,
        Markets,
        Loyalty
    }

    public enum RootParentId
    {
        Food = -1,
        Other = -2,
        Source = -3
    }

    public enum Operations
    {
        Outcome = 1,
        Income,
        Transfer
    }

    public enum DiffDlg
    {
        Ok,
        DiffToGoods,
        DiffToTotal,
        EditReceipt
    }

    public enum MessageSenders
    {
        AccountsPage,
        DebtsPage,
        IncomingsPage,
        MarketsPage,
        OutcomingsPage,
        IncomingForm,
        IncomingJournal,
        OutcomingForm,
        OutcomingCategories,
        OutcomingJournal
    }

}
