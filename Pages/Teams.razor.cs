using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace LeaguePulse.Pages
{
    public partial class Teams : ComponentBase
    {
        [Inject] private HttpClient Http { get; set; }

        private Team[]? teams;

        protected override async Task OnInitializedAsync()
        {
            teams = await Http.GetFromJsonAsync<Team[]>("sample-data/EELG_teams.json");
        }
    }
}
