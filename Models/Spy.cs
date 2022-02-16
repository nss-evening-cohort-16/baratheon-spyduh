namespace SpyDuh_Baratheon.Models
{
    public class Spy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> SkillIds { get; set; }
        public List<int> ServiceIds { get; set; }
        public List<int> FriendIds { get; set; }
        public List<int> EnemyIds { get; set; }
    }
}
