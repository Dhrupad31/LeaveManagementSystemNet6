namespace LeaveManagement.Web.Data
{
    public abstract class BaseEntity //Instead of repeating these following Ids in LeaveAllocation and LeaveType tables, we can create a BaseEntity and make the tables inherit from the BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
