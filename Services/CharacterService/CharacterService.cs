using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnet5_RPG.Controllers.Models;
using Dotnet5_RPG.Models;

namespace Dotnet5_RPG.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character> 
        {
            new Character(),
            new Character { Id = 1, Name = "Sam"}
        }; 
        
        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var serviceRespsone = new ServiceResponse<List<Character>>();
            characters.Add(newCharacter);
            serviceRespsone.Data = characters;
            return serviceRespsone;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            var serviceRespsone = new ServiceResponse<List<Character>>();
            serviceRespsone.Data = characters;
            return serviceRespsone;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var serviceRespsone = new ServiceResponse<Character>();
            serviceRespsone.Data = characters.FirstOrDefault(c => c.Id == id);
            return serviceRespsone;
        }
    }
}