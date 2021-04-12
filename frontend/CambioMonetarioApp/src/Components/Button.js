import React from 'react';
import {
  StyleSheet,
  Text,
  Dimensions,
  TouchableHighlight
} from 'react-native';

const styles = StyleSheet.create({
  button: {
    fontSize: 40,
    height: Dimensions.get('window').width / 3,
    width: Dimensions.get('window').width / 3,
    padding: 20,
    backgroundColor: '#FFFCE6',
    textAlign: 'center',
    borderColor: '#888'
  },
  operationButton: {
    color: '#fff',
    backgroundColor: '#fa8231',
  },
  buttonDouble: {
    width: (Dimensions.get('window').width / 4) * 3,
  },
  buttonTriple: {
    width: (Dimensions.get('window').width / 4 ) * 3,
  }
})

const  Button = (props) => {

  const stylesButton = [styles.button]

  if(props.double) stylesButton.push(styles.buttonDouble);
  if(props.triple) stylesButton.push(styles.buttonTriple);
  if(props.operation) stylesButton.push(styles.operationButton)
  return (
    <TouchableHighlight >
      <Text style={stylesButton}>
      {props.label}
      </Text>
    </TouchableHighlight>
  )
}

export default Button;