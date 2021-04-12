import React from 'react';
import { View, StyleSheet} from 'react-native';
import Keyboard from './Components/Keyboard';
import Header from './Components/Header';
import Display from './Components/Display';
import { CurrencyProviders } from './context/CurrencyContext'

import api from '../src/config/api';

import {Picker} from '@react-native-picker/picker';

const initialState = {
  base: null,
}



const App = (props) =>{

  addDigit = n => {
    /*console.debug(typeof this.state.displayValue)
    
    const clearDisplay = this.state.displayValue === '0'
      || this.state.clearDisplay
    
    if (n === '.' && !clearDisplay 
      && this.state.displayValue.includes('.')) {
      return
    }*/
  }

 
  const enviar = () =>{
    getCurrency();
  } 

  return(
   <CurrencyProviders> 
    <View style={estilo.container}>
      <Display coin="R$" value={0}/>
      <Display coin="$" value={0} />
      <View style={estilo.button}>
        <Keyboard />
      </View>
    </View>
  </CurrencyProviders>
  )
}

const estilo = StyleSheet.create({
  container:{
    flex: 1,
    backgroundColor: '#fff'
  },
  button: {
    flexDirection: 'row',
    flexWrap: 'wrap'
  },
})

export default App;