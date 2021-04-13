import React, {useContext} from 'react';
import Button from './Button';
import CurrencyContext from '../context/CurrencyContext';



const Keyboard = () =>{

  const {state, dispatch } = useContext(CurrencyContext)


    addDigit = n => {
      alert("clicou " + n)
      //console.warn(state);
      console.log(state.display[0].clearDisplay,"sou o valor")
      console.debug(typeof state.display.displayValue)
      
      const clearDisplay = state.display[0].value === '0'
        || state.display[0].clearDisplay
      
      if (n === '.' && !clearDisplay 
        && state.display[0].value.includes('.')) {
        return
      }
  
      const currentValue = clearDisplay ? '' : state.display[0].value
      const displayValue = currentValue + n
      dispatch({ type: 'mudarDisplay', payload : [{displayValue, clearDisplay: false}] })
  
      if (n !== '.') {
        const newValue = parseFloat(displayValue)
        const values = [...state.values]
        values[state.current] = newValue
        console.log(values);
        dispatch({type: 'mudarDisplay', payload: [{values}]})
      }
    }

    return(
      <>
        <Button label='7'  onClick={() => addDigit(7)} />
        <Button label='8'  onClick={() => addDigit(8)} />
        <Button label='9'  onClick={() => addDigit(9)} />
        <Button label='4'  onClick={() => addDigit(4)} />
        <Button label='5'  onClick={() => addDigit(5)} />
        <Button label='6'  onClick={() => addDigit(6)} />
        <Button label='1'  onClick={() => addDigit(1)} />
        <Button label='2'  onClick={() => addDigit(2)} />
        <Button label='3'  onClick={() => addDigit(3)} />
        <Button label='0'  onClick={() => addDigit(0)} />
        <Button label='.'  onClick={() => addDigit('.')} />
        <Button label='DEL' double onClick={() => addDigit('DEL')} />
      </>
    );
}

export default Keyboard;