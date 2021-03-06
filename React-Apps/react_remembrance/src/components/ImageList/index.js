import React from 'react';


class Image extends React.Component {

  state = {
    clickedAlready: false
  }

  componentDidUpdate = (prevProps) => {

    if (prevProps.score !== this.props.score && this.props.score === 0) {
      this.setState({ clickedAlready: false })
    }

  }

  handleClickEvent = (e) => {
    const { increaseScore, content } = this.props
    let sourceUrl = e.target.src;

    if (sourceUrl.includes(content)) {
      increaseScore(content);
      this.setState({ clickedAlready: true })
    }
  }

  render() {
    const { content } = this.props

    return (
      <img
        alt='broccoli'
        src={content}
        onClick={this.handleClickEvent}
        className='four wide column'
        style={{ 'border': '1px solid grey' }}>
      </img>

    )
  }
}


export default Image;

