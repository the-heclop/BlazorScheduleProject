using Microsoft.AspNetCore.Components;
using BlazorTest1.Modelss;
using BlazorTest1.DataAccess;

namespace BlazorTest1.Pages
{
    public partial class Register
    {
        private User _user = new();
        private BCryptPasswordHasher _passwordHasher = new();
        private async Task HandleValidSubmit()
        {
            _user.Password = _passwordHasher.HashPassword(_user.Password);
            DbContext.TokenUsers.Add(_user);
            await DbContext.SaveChangesAsync();
            NavigationManager.NavigateTo("/");
        }
    }
}