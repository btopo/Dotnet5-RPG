using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dotnet5_RPG.Controllers.Models;
using Dotnet5_RPG.Dtos.Character;
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
        private readonly IMapper _mapper;

        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            var serviceRespsone = new ServiceResponse<List<GetCharacterDto>>();
            Character character = _mapper.Map<Character>(newCharacter);
            character.Id = characters.Max(c => c.Id) + 1; // this is where the Id of a new character is added
            characters.Add(character);
            serviceRespsone.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return serviceRespsone;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            var serviceRespsone = new ServiceResponse<List<GetCharacterDto>>();
            serviceRespsone.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return serviceRespsone;
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<GetCharacterDto>();
            serviceResponse.Data = _mapper.Map<GetCharacterDto>(characters.FirstOrDefault(c => c.Id == id));
            return serviceResponse;
        }
    }
}