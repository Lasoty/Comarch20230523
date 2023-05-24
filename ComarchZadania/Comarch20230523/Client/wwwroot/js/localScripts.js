// _Imports.razor lub inny plik JavaScript

// Funkcja do pobierania obrazu jako tablicy bajtów
window.pobierzObrazJakoBytes = async function (url) {
  const response = await fetch(url);
  const arrayBuffer = await response.arrayBuffer();
  const byteArray = new Uint8Array(arrayBuffer);
  return Array.from(byteArray);
};

// Funkcja do zapisu tablicy bajtów jako plik na lokalnym urządzeniu
window.zapiszObrazLokalnie = function (nazwaPliku, byteArray) {
  const a = document.createElement('a');
  const blob = new Blob([new Uint8Array(byteArray)], { type: 'image/jpeg' });
  const url = URL.createObjectURL(blob);
  a.href = url;
  a.download = nazwaPliku;
  document.body.appendChild(a);
  a.click();
  document.body.removeChild(a);
  URL.revokeObjectURL(url);
};
