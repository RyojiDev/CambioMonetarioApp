import React from 'react';
import { View, StyleSheet} from 'react-native';
import Keyboard from './Components/Keyboard';
import Header from './Components/Header';
import Display from './Components/Display';
import { CurrencyProviders } from './context/CurrencyContext'


import {Picker} from '@react-native-picker/picker';

class App extends React.Component{

  render(){
    return(
      <CurrencyProviders> 
       <View style={estilo.container}>
         <Display coin="R$" value={0}/>
         <Display coin="$"  value={0} />
         <View style={estilo.button}>
           <Keyboard clicar={this.addDigit}/>
         </View>
       </View>
     </CurrencyProviders>
     )
  }
 
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