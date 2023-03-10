using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dotnet5_RPG.Controllers.Models;
using Dotnet5_RPG.Dtos.Character;
using Dotnet5_RPG.Dtos.Skill;
using Dotnet5_RPG.Dtos.Weapon;
using Dotnet5_RPG.Migrations;

namespace Dotnet5_RPG
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();  // maping the Character to GetCharacterDto
            CreateMap<AddCharacterDto, Character>();  // maping the AddCharacter to Character
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
        }
    }
}   