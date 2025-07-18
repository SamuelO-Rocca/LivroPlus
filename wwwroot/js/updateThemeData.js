// Livro_.wwwroot.js

function updateThemeData(theme) {
    $.ajax({
        type: 'POST',
        url: '@Url.Action("SetTheme", "Home")',
        data: { theme: theme },
        success: function () {
            console.log('Theme updated successfully');
            updateThemeToggleText();
        },
        error: function () {
            console.error('Error updating theme');
        }
    });
}

function updateThemeToggleText() {
    const themeToggle = document.querySelector('.theme-toggle');
    themeToggle.textContent = themeStylesheet.href.includes('dark-theme') ? 'Modo Claro' : 'Modo Escuro';
}
