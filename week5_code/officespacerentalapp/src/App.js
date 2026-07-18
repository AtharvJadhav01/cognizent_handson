function App() {
  const element = "Office Space";

  const offices = [
    {
      Name: "DBS",
      Rent: 50000,
      Address: "Chennai",
      Image:
        "https://images.unsplash.com/photo-1497366811353-6870744d04b2?w=400"
    },
    {
      Name: "Regus",
      Rent: 65000,
      Address: "Mumbai",
      Image:
        "https://images.unsplash.com/photo-1497366754035-f200968a6e72?w=400"
    }
  ];

  return (
    <div style={{ margin: "50px" }}>
      <h1>{element}, at Affordable Range</h1>

      {offices.map((office, index) => (
        <div key={index} style={{ marginBottom: "40px" }}>
          <img
            src={office.Image}
            width="250"
            height="200"
            alt="Office Space"
          />

          <h1>Name: {office.Name}</h1>

          <h3
            style={{
              color: office.Rent <= 60000 ? "red" : "green"
            }}
          >
            Rent: Rs. {office.Rent}
          </h3>

          <h3>Address: {office.Address}</h3>
        </div>
      ))}
    </div>
  );
}

export default App;