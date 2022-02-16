using SpyDuh_Baratheon.Models;

namespace SpyDuh_Baratheon.DataAccess
{
    public class SkillsRepository
    {
        public static List<Skills> SkillsList = new List<Skills>()
        {
            new Skills()
            {
                Id = 1,
                skillName = "Lock-picking"
            },
            new Skills()
            {
                Id = 2,
                skillName = "Kung-Fu"
            },
            new Skills()
            {
                Id = 3,
                skillName = "Cyphering"
            },
            new Skills()
            {
                Id = 4,
                skillName = "Translation"
            },
            new Skills()
            {
                Id = 5,
                skillName = "Marksmanship"
            },
            new Skills()
            {
                Id = 6,
                skillName = "Encryption"
            },
            new Skills()
            {
                Id = 7,
                skillName = "Espionoge"
            },
            new Skills()
            {
                Id = 8,
                skillName = "Seduction"
            },
            new Skills()
            {
                Id = 9,
                skillName = "Deception"
            },
            new Skills()
            {
                Id = 10,
                skillName = "Speed-Reading"
            }
        };

        internal List<Skills> GetAll()
        {
            return SkillsList;
        }
    }
}
