namespace SpyDuh_Baratheon.Models
{
    public class Spy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Skills> Skills { get; set; }
        public List<int> FriendIds { get; set; }
        public List<int> EnemyIds { get; set; }
    }
}
