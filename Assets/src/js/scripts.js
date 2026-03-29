window.addEventListener('DOMContentLoaded', () => {
    let scrollPos = 0;
    const mainNav = document.getElementById('mainNav');
    
    // --- NEW: Dynamic Spacer Height Calculation ---
    const setSpacerHeight = () => {
        if (mainNav) {
            const navHeight = mainNav.clientHeight;
            // Set the CSS variable on the root document
            document.documentElement.style.setProperty('--nav-height', `${navHeight}px`);
        }
    };
    
    // Calculate on load
    setSpacerHeight();
    
    // Recalculate if the window is resized
    window.addEventListener('resize', setSpacerHeight);
    // ----------------------------------------------
    const headerHeight = mainNav.clientHeight;
    window.addEventListener('scroll', function() {
        const currentTop = document.body.getBoundingClientRect().top * -1;
        if ( currentTop < scrollPos) {
            // Scrolling Up
            if (currentTop > 0 && mainNav.classList.contains('is-fixed')) {
                mainNav.classList.add('is-visible');
            } else {
                console.log(123);
                mainNav.classList.remove('is-visible', 'is-fixed');
            }
        } else {
            // Scrolling Down
            mainNav.classList.remove(['is-visible']);
            if (currentTop > headerHeight && !mainNav.classList.contains('is-fixed')) {
                mainNav.classList.add('is-fixed');
            }
        }
        scrollPos = currentTop;
    });
})
