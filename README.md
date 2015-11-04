# TwitterCardsTagHelpers
A Twitter Cards as TagHelper

## Design

Consider WebComponent like markup you can find in other places:
```html
<Card
    image='http://pitchfork-cdn.s3.amazonaws.com/longform/221/Deerhunter-Fading-Frontier640.jpg'
    text='A Deerhunter album rollout usually coincides with some pithy and provocative statements from Bradford Cox on pop culture...'
    title='Deerhunter'
    subtitle='Fading Frontier'
    color="rgba(0,0,0,.4)"
    actions={actions}
  />
```
This is from React: [http://react-toolbox.com/#/components/card](http://react-toolbox.com/#/components/card)

```html
<paper-card heading="Card Title">
  <div class="card-content">Some content</div>
  <div class="card-actions">
    <paper-button>Some action</paper-button>
  </div>
</paper-card>
```
This one is from Polymer project Paper elements: [https://elements.polymer-project.org/elements/paper-card](https://elements.polymer-project.org/elements/paper-card)

In ASP.NET5 that is possible to have wecomponent like custom markup. For example having:
```html
<twitter-summary site="@flickr"
  title="Small Island Developing States Photo Submission"
  description="View the album on Flickr."
  image="https://farm6.staticflickr.com/5510/14338202952_93595258ff_z.jpg" />
```
Output:
```html
<meta name="twitter:card" content="summary" />
<meta name="twitter:site" content="@flickr" />
<meta name="twitter:title" content="Small Island Developing States Photo Submission" />
<meta name="twitter:description" content="View the album on Flickr." />
<meta name="twitter:image" content="https://farm6.staticflickr.com/5510/14338202952_93595258ff_z.jpg" />
```

Usage:
```cshtml
<environment names="Production">
  <twitter-summary site="@flickr"
    title="Small Island Developing States Photo Submission"
    description="View the album on Flickr."
    image="https://farm6.staticflickr.com/5510/14338202952_93595258ff_z.jpg" />
</environment>
```

## Author
@peterblazejewicz
