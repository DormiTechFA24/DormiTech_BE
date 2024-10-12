namespace Application.IServices
{
    public interface IClaimsServices
    {
        //Lấy id User hiện tại
        public int GetCurrentUserId { get; }
    }
}