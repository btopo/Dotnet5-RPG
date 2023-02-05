using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnet5_RPG.Dtos.Character;
using Dotnet5_RPG.Dtos.Weapon;
using Dotnet5_RPG.Models;

namespace Dotnet5_RPG.Services.CharacterService.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}