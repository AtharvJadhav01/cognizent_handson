import React from 'react';

const IndianTeam = [
  'Sachin1',
  'Dhoni2',
  'Virat3',
  'Rohit4',
  'Yuvaraj5',
  'Raina6'
];

export function OddPlayers([first, , third, , fifth]) {
  return (
    <div>
      <li>First: {first}</li>
      <li>Third: {third}</li>
      <li>Fifth: {fifth}</li>
    </div>
  );
}

export function EvenPlayers([, second, , fourth, , sixth]) {
  return (
    <div>
      <li>Second: {second}</li>
      <li>Fourth: {fourth}</li>
      <li>Sixth: {sixth}</li>
    </div>
  );
}

const T20players = [
  'First Player',
  'Second Player',
  'Third Player'
];

const RanjiTrophyPlayers = [
  'Fourth Player',
  'Fifth Player',
  'Sixth Player'
];

export const IndianPlayers = [
  ...T20players,
  ...RanjiTrophyPlayers
];

export function ListofIndianPlayers({ IndianPlayers }) {
  return (
    <div>
      {IndianPlayers.map((player, index) => (
        <li key={index}>Mr. {player}</li>
      ))}
    </div>
  );
}

export { IndianTeam };