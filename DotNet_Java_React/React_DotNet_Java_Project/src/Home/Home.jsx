export const Home = () => {
  return (
    <div style={{
      display: 'flex',
      flexDirection: 'column',
      alignItems: 'center',
      justifyContent: 'center',
      height: '90vh',
      backgroundColor: '#f8f9fa',
      fontFamily: 'Segoe UI, sans-serif',
      textAlign: 'center',
      padding: '20px'
    }}>
      <h1 style={{ color: '#0d6efd', marginBottom: '20px' }}>
        🚗 Welcome to Spare_Part_Wala!
      </h1>
      <h4 style={{ color: '#495057', marginBottom: '30px' }}>
        Your one-stop shop for all genuine spare parts – fast, reliable, and trusted.
      </h4>
      <hr style={{ width: '50%' }} />
      <h6 style={{ marginTop: '30px', color: '#6c757d' }}>
        Designed & Developed with ❤️ by <strong>Prasad Patil</strong>
      </h6>
      <p style={{ fontStyle: 'italic', color: '#343a40', marginTop: '10px' }}>
        "Powering every ride with quality you can trust."
      </p>
    </div>
  );
}
