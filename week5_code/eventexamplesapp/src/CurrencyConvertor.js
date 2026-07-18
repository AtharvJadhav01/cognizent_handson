import React, { Component } from 'react';

class CurrencyConvertor extends Component {
  constructor(props) {
    super(props);

    this.state = {
      amount: '',
      currency: ''
    };
  }

  handleAmountChange = (event) => {
    this.setState({
      amount: event.target.value
    });
  };

  handleCurrencyChange = (event) => {
    this.setState({
      currency: event.target.value
    });
  };

  handleSubmit = (event) => {
    event.preventDefault();

    const rupees = parseFloat(this.state.amount);

    if (this.state.currency.toLowerCase() === 'euro') {
      const euro = rupees / 90;

      alert(
        'Converting to Euro. Amount is ' + euro.toFixed(2)
      );
    } else {
      alert('Please enter Euro as currency');
    }
  };

  render() {
    return (
      <div>
        <h1 style={{ color: 'green' }}>
          Currency Convertor!!!
        </h1>

        <form onSubmit={this.handleSubmit}>
          <label>
            Amount:
            <input
              type="number"
              value={this.state.amount}
              onChange={this.handleAmountChange}
            />
          </label>

          <br />
          <br />

          <label>
            Currency:
            <input
              type="text"
              value={this.state.currency}
              onChange={this.handleCurrencyChange}
            />
          </label>

          <br />
          <br />

          <button type="submit">
            Submit
          </button>
        </form>
      </div>
    );
  }
}

export default CurrencyConvertor;