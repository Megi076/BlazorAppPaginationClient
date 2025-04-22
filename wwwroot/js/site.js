// Функција за извоз на CSV
function saveAsFile(filename, content) {
    console.log('Starting CSV export');
    var blob = new Blob([content], { type: 'text/csv;charset=utf-8;' });
    var link = document.createElement("a");
    link.href = URL.createObjectURL(blob);
    link.download = filename;
    link.click();
    console.log('CSV export complete');
}

// Функција за извоз на Excel
function saveExcel(filename, data) {
    console.log('Starting Excel export');
    var ws = XLSX.utils.aoa_to_sheet(data);
    var wb = XLSX.utils.book_new();
    XLSX.utils.book_append_sheet(wb, ws, "Taxi Rides");
    XLSX.writeFile(wb, filename);
    console.log('Excel export complete');
}

// Функција за извоз на PDF
function savePdf(filename, content) {
    console.log('Starting PDF export');
    const { jsPDF } = window.jspdf;
    const doc = new jsPDF();

    doc.text(content, 10, 10);
    doc.save(filename);
    console.log('PDF export complete');
}


