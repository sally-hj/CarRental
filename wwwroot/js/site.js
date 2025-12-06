// Gestion de l'authentification
function checkAuth() {
    return localStorage.getItem('isLoggedIn') === 'true';
}

function getUserInfo() {
    return {
        isLoggedIn: checkAuth(),
        email: localStorage.getItem('userEmail') || '',
        name: localStorage.getItem('userName') || ''
    };
}

// Redirection après connexion
function redirectAfterAuth(returnUrl) {
    if (checkAuth()) {
        window.location.href = returnUrl || '/';
    }
}

// Gestion des dates
function formatDate(date) {
    return new Date(date).toLocaleDateString('fr-FR');
}

// Calcul des jours
function calculateDays(startDate, endDate) {
    const start = new Date(startDate);
    const end = new Date(endDate);
    const diffTime = Math.abs(end - start);
    return Math.ceil(diffTime / (1000 * 60 * 60 * 24));
}

// Initialisation au chargement
document.addEventListener('DOMContentLoaded', function () {
    // Vérifier l'authentification
    if (checkAuth() && window.location.pathname.includes('Login')) {
        window.location.href = '/';
    }

    // Initialiser les tooltips Bootstrap
    var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
    var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
        return new bootstrap.Tooltip(tooltipTriggerEl);
    });

    // Pour les boutons de déconnexion
    const logoutButtons = document.querySelectorAll('[data-logout]');
    logoutButtons.forEach(button => {
        button.addEventListener('click', function (e) {
            e.preventDefault();
            localStorage.removeItem('isLoggedIn');
            localStorage.removeItem('userEmail');
            localStorage.removeItem('userName');
            window.location.href = '/Account/Login';
        });
    });

    // Gestion des boutons "Réserver" dans la page voitures
    const reserveButtons = document.querySelectorAll('.reserve-btn');
    reserveButtons.forEach(button => {
        button.addEventListener('click', function () {
            const carId = this.getAttribute('data-car-id');
            const carName = this.getAttribute('data-car-name');

            // Stocker pour plus tard
            sessionStorage.setItem('selectedCarId', carId);
            sessionStorage.setItem('selectedCarName', carName);

            // Vérifier si connecté
            if (!checkAuth()) {
                // Rediriger vers login avec returnUrl
                const returnUrl = `/Reservation/Create?carId=${carId}`;
                window.location.href = `/Account/Login?returnUrl=${encodeURIComponent(returnUrl)}`;
            } else {
                // Rediriger directement vers réservation
                window.location.href = `/Reservation/Create?carId=${carId}`;
            }
        });
    });
});