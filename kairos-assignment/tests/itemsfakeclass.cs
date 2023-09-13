using ItemsApi.Models;
using ItemsApi.Services;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public class ItemServiceFake : ItemsService
{
    private readonly List<Items> _items;


    public ItemServiceFake() => _items = new List<Items>()
    {
        new Items() {
            Id = new string("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200"),
            name = "Orange Juice",
            company="Orange Tree"
        },
        new Items() {
            Id = new string("815accac-fd5b-478a-a9d6-f171a2f6ae7f"),
            name = "Diary Milk",
            company="Cow"
        },
        new Items() {
            Id = new string("33704c4a-5b87-464c-bfb6-51971b4d18ad"),
            name = "Frozen Pizza",
            company="Uncle Mickey"
        }
    };

    public IEnumerable<Items> GetAllItems()
    {
        return _items;
    }

    public Items Add(Items newItem)
    {
        newItem.Id = RandomString(36);
        _items.Add(newItem);
        return newItem;
    }

    private static Random random = new Random();

    public static string RandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}