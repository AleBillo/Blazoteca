# Blazoteca
 Progetto Blazor 5^F

---
## Documentazione: come modificare il layout di default del template Blazor
### Primo step
Crea, all'interno della cartella Shared, un file `.razor` che contiene il layout custom. **DEVE obbligatoriamente contenere la direttiva `@inherits LayoutComponentBase` e, di conseguenza, implementare da qualche parte `@Body` (il corpo del sito)**.

### Secondo step
Entra all'interno di `App.razor` e rimpiazza tutte le occorrenze di "MainLayout" con il nome del file del custom layout.

---
## Documentazione: come caricare il Bootstrap Bundle
### Primo step: ottieni il bundle
Copia tutto il file minificato e incollalo in un file chiamato `bootstrap.bundle.min` situato nel primo livello della cartella `wwwroot`.

### Secondo step: collega il file al progetto
Cerca `_Layout.cshtml` nella cartella `Pages` e includi il file come se fosse un normale script JS.
