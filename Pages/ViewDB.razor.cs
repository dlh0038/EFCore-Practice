namespace final_efcoretest.Pages {
    public partial class ViewDB
    {
        List<User> Users = new List<User>();
        protected override async Task OnInitializedAsync()
        {
            await RefreshProducts();
        }

        private async Task RefreshProducts()
        {
            Users = await service.GetUserAsync();
        }

        public User NewProduct { get; set; } = new User();
        private async Task AddNewUser()
        {
            await service.AddUserAsync(NewProduct);
            NewProduct = new User();
            await RefreshProducts();
        }

        User UpdateProduct = new User();
        private void SetProductForUpdate(User product)
        {
            UpdateProduct = product;
        }

        private async Task UpdateProductData()
        {
            await service.UpdateUserAsync(UpdateProduct);
            await RefreshProducts();
        }

        private async Task DeleteProduct(User product)
        {
            await service.DeleteUserAsync(product);
            await RefreshProducts();
        } 
    }
}