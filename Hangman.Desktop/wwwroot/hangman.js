document.addEventListener('keydown', event => {
    if (event.altKey || event.ctrlKey || event.metaKey || event.repeat) return;
    const letter = event.key.toUpperCase();
    if (!/^[A-Z]$/.test(letter)) return;
    const button = document.querySelector(`button[aria-label="Guess ${letter}"]:not(:disabled)`);
    if (button) {
        event.preventDefault();
        button.click();
    }
});
