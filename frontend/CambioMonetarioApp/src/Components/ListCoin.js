import React, {useContext} from 'react';
import {StyleSheet, View, Text} from 'react-native';
import {Picker} from '@react-native-community/picker';
import CurrencyContext from '../context/CurrencyContext';




const ListCoin = (props) =>{

  const {state, dispatch } = useContext(CurrencyContext)
  const ctx  = useContext(CurrencyContext)
  console.warn(Object.keys(ctx.state))
  console.log(state);
  return(
    
     <Picker
      style={styles.PickerComponent}
      mode="dropdown"
      selectedValue=""
      onValueChange={(itemValor,itemIndex) =>{
        setCountry({
          country: itemValor
        })
      }}>
      
    </Picker>
  )
}
const styles = StyleSheet.create({
  PickerComponent:{
    width: '100%'
  },
  textoSelecionado: {
    fontWeight: 'bold',
    fontSize: 30,
    color: '#fff'
  }
})

export default ListCoin;