using SpyDuh_Baratheon.Models;

namespace SpyDuh_Baratheon.DataAccess
{
    public class SpiesRepository
    {
        private static List<Spy> _spies = new List<Spy>()
        {
            new Spy()
            {
                Id = 1,
                Name = "Robert Baratheon",
                SkillIds = new List<int>() {
                    2, 3, 5, 6, 8, 9
                },
                ServiceIds = new List<int>() {
                },
                FriendIds = new List<int> {
                    2, 3, 5, 6,
                },
                EnemyIds = new List<int> {
                    4, 7,
                }
            },
            new Spy()
            {
                Id = 2,
                Name = "Cersei Lannister",
                SkillIds = new List<int>() {
                    3, 4, 6, 7, 8, 9, 10
                },
                ServiceIds = new List<int>() {
                },
                FriendIds = new List<int> {
                    1, 3, 5, 6,
                },
                EnemyIds = new List<int> {
                    4, 7,
                }
            },
            new Spy()
            {
                Id = 3,
                Name = "Joffrey Baratheon",
                SkillIds = new List<int>() {
                    5, 7, 9
                },
                ServiceIds = new List<int>() {
                },
                FriendIds = new List<int> {
                    1, 2, 4, 5, 
                },
                EnemyIds = new List<int> {
                    6, 7,
                }
            },
            new Spy()
            {
                Id = 4,
                Name = "Margaery Tyrell",
                SkillIds = new List<int>() {
                    3, 4, 6, 7, 8, 9, 10
                },
                ServiceIds = new List<int>() {
                },
                FriendIds = new List<int> {
                    1, 3,
                },
                EnemyIds = new List<int> {
                    2, 6, 7,
                }
            },
            new Spy()
            {
                Id = 5,
                Name = "Myrcella Baratheon",
                SkillIds = new List<int>() {
                    3, 5, 6, 8
                },
                ServiceIds = new List<int>() {
                },
                FriendIds = new List<int> {
                    1, 2, 3, 6, 7
                },
                EnemyIds = new List<int> {
                }
            },
            new Spy()
            {
                Id = 6,
                Name = "Tommen Baratheon",
                SkillIds = new List<int>() {
                    1, 2, 4, 5
                },
                ServiceIds = new List<int>() {
                },
                FriendIds = new List<int> {
                    1, 2, 5, 7,
                },
                EnemyIds = new List<int> {
                    3, 4,
                }
            },
            new Spy()
            {
                Id = 7,
                Name = "Stannis Baratheon",
                SkillIds = new List<int>() {
                    1, 2, 3, 5, 6, 7, 9
                },
                ServiceIds = new List<int>() {
                },
                FriendIds = new List<int> {
                    5, 6,
                },
                EnemyIds = new List<int> {
                    1, 2, 3, 4,
                }
            },
        };


        // GET
        internal object GetByName(string _name)
        {
            var match = _spies.FirstOrDefault(s => s.Name == _name);
            return match;
        }
        internal object GetById(int _id)
        {
            var match = _spies.FirstOrDefault(s => s.Id == _id);
            return match;
        }

        internal List<int> GetFriendIds(Spy _spy)
        {
            return _spy.FriendIds;
        }

        internal List<int> GetEnemyIds(Spy _spy)
        {
            return _spy.EnemyIds;
        }

        internal List<Spy> GetAll()
        {
            return _spies;
        }

        // POST
        internal void Post(Spy _spy)
        {
            _spies.Add(_spy);
        }
    }
}
