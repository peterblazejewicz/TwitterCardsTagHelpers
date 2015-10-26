# TwitterCardsTagHelpers
A Twitter Cards as TagHelper

## Design

Having:
```cshtml
<twitter-card type="summary"
  site="@flickr"
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
  <twitter-card type="summary"
    site="@flickr"
    title="Small Island Developing States Photo Submission"
    description="View the album on Flickr."
    image="https://farm6.staticflickr.com/5510/14338202952_93595258ff_z.jpg" />
</environment>
```

## Author
@peterblazejewicz
