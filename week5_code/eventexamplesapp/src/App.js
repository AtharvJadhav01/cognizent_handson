import React, { Component } from 'react';

class App extends Component {
  constructor(props) {
    super(props);

    this.state = {
      count: 0
    };
  }

  increment = () => {
    this.setState({
      count: this.state.count + 1
    });
  };

  decrement = () => {
    this.setState({
      count: this.state.count - 1
    });
  };

  sayHello = () => {
    alert('Hello! Member');
  };

  incrementAndSayHello = () => {
    this.increment();
    this.sayHello();
  };

  sayWelcome = (message) => {
    alert(message);
  };

  handleClick = (event) => {
    alert('I was clicked');
  };

  render() {
    return (
      <div>
        <h2>{this.state.count}</h2>

        <button onClick={this.incrementAndSayHello}>
          Increment
        </button>

        <br />

        <button onClick={this.decrement}>
          Decrement
        </button>

        <br />

        <button onClick={() => this.sayWelcome('Welcome')}>
          Say Welcome
        </button>

        <br />

        <button onClick={this.handleClick}>
          Click on me
        </button>
      </div>
    );
  }
}

export default App;