export const Footer = () => {
  const year = new Date().getFullYear();

  return (
    <footer style={{
      textAlign: 'center',
      padding: '15px 0',
      backgroundColor: '#f1f1f1',
      color: '#6c757d',
      fontSize: '14px',
      borderTop: '1px solid #dee2e6',
      marginTop: 'auto' // ensures it stays at bottom only when content is short
    }}>
      <p>
        &copy; {year} <strong>Spare_Part_Wala</strong>. All rights reserved. <br />
        <span style={{ fontStyle: 'italic' }}>Crafted with passion by Prasad Patil 🚀</span>
      </p>
    </footer>
  );
};
