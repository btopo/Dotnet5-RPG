using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnet5_RPG.Controllers.Models;

namespace Dotnet5_RPG.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAllCharacters();
        Task<Character> GetCharacterById(int id);
        Task<List<Character>> AddCharacter(Character newCharacter);
    }
}