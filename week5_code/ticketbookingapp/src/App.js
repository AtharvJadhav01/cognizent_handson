import React, { Component } from 'react';

function GuestPage() {
  return (
    <div>
      <h1>Please sign up.</h1>

      <h2>Flight Details</h2>
      <p>Flight: Air India</p>
      <p>From: Mumbai</p>
      <p>To: Delhi</p>
      <p>Price: Rs. 5000</p>

      <p>Please login to book tickets.</p>
    </div>
  );
}

function UserPage() {
  return (
    <div>
      <h1>Welcome back</h1>

      <h2>Flight Details</h2>
      <p>Flight: Air India</p>
      <p>From: Mumbai</p>
      <p>To: Delhi</p>
      <p>Price: Rs. 5000</p>

      <button>Book Ticket</button>
    </div>
  );
}

function LoginButton(props) {
  return (
    <button onClick={props.onClick}>
      Login
    </button>
  );
}

function LogoutButton(props) {
  return (
    <button onClick={props.onClick}>
      Logout
    </button>
  );
}

function Greeting(props) {
  const isLoggedIn = props.isLoggedIn;

  if (isLoggedIn) {
    return <UserPage />;
  }

  return <GuestPage />;
}

class App extends Component {
  constructor(props) {
    super(props);

    this.state = {
      isLoggedIn: false
    };
  }

  handleLoginClick = () => {
    this.setState({
      isLoggedIn: true
    });
  };

  handleLogoutClick = () => {
    this.setState({
      isLoggedIn: false
    });
  };

  render() {
    const isLoggedIn = this.state.isLoggedIn;

    let button;

    if (isLoggedIn) {
      button = (
        <LogoutButton onClick={this.handleLogoutClick} />
      );
    } else {
      button = (
        <LoginButton onClick={this.handleLoginClick} />
      );
    }

    return (
      <div>
        <Greeting isLoggedIn={isLoggedIn} />
        {button}
      </div>
    );
  }
}

export default App;