<mxfile host="app.diagrams.net" modified="2023-12-15T12:00:00.000Z" agent="5.0 (Windows)" etag="abcdefgh12345" version="15.8.6">
  <diagram id="tripplanner-db" name="TripPlanner DB">
    <mxGraphModel dx="1422" dy="798" grid="1" gridSize="10" guides="1" tooltips="1" connect="1" arrows="1" fold="1" page="1" pageScale="1" pageWidth="850" pageHeight="1100" math="0" shadow="0">
      <root>
        <mxCell id="0" />
        <mxCell id="1" parent="0" />
        
        <!-- User Entity -->
        <mxCell id="user" value="User" style="swimlane;fontStyle=0;childLayout=stackLayout;horizontal=1;startSize=26;fillColor=#dae8fc;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;strokeColor=#6c8ebf;" parent="1" vertex="1">
          <mxGeometry x="590" y="360" width="180" height="156" as="geometry" />
        </mxCell>
        <mxCell id="user-id" value="id UUID" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontStyle=4" parent="user" vertex="1">
          <mxGeometry y="26" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="user-name" value="name VARCHAR(100)" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="user" vertex="1">
          <mxGeometry y="52" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="user-email" value="email VARCHAR(unique)" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="user" vertex="1">
          <mxGeometry y="78" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="user-password" value="password VARCHAR" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="user" vertex="1">
          <mxGeometry y="104" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="user-avatar" value="avatar VARCHAR" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="user" vertex="1">
          <mxGeometry y="130" width="180" height="26" as="geometry" />
        </mxCell>
        
        <!-- Trip Entity -->
        <mxCell id="trip" value="Trip" style="swimlane;fontStyle=0;childLayout=stackLayout;horizontal=1;startSize=26;fillColor=#dae8fc;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;strokeColor=#6c8ebf;" parent="1" vertex="1">
          <mxGeometry x="310" y="200" width="180" height="208" as="geometry" />
        </mxCell>
        <mxCell id="trip-id" value="id UUID" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontStyle=4" parent="trip" vertex="1">
          <mxGeometry y="26" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="trip-title" value="title VARCHAR(200)" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="trip" vertex="1">
          <mxGeometry y="52" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="trip-description" value="description TEXT" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="trip" vertex="1">
          <mxGeometry y="78" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="trip-startDate" value="startDate DATE" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="trip" vertex="1">
          <mxGeometry y="104" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="trip-endDate" value="endDate DATE" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="trip" vertex="1">
          <mxGeometry y="130" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="trip-status" value="status ENUM" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="trip" vertex="1">
          <mxGeometry y="156" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="trip-ownerId" value="ownerId UUID (FK)" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="trip" vertex="1">
          <mxGeometry y="182" width="180" height="26" as="geometry" />
        </mxCell>
        
        <!-- Point Entity -->
        <mxCell id="point" value="Point" style="swimlane;fontStyle=0;childLayout=stackLayout;horizontal=1;startSize=26;fillColor=#dae8fc;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;strokeColor=#6c8ebf;" parent="1" vertex="1">
          <mxGeometry x="50" y="220" width="180" height="156" as="geometry" />
        </mxCell>
        <mxCell id="point-id" value="id UUID" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontStyle=4" parent="point" vertex="1">
          <mxGeometry y="26" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="point-name" value="name VARCHAR" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="point" vertex="1">
          <mxGeometry y="52" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="point-description" value="description TEXT" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="point" vertex="1">
          <mxGeometry y="78" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="point-latitude" value="latitude FLOAT" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="point" vertex="1">
          <mxGeometry y="104" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="point-longitude" value="longitude FLOAT" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="point" vertex="1">
          <mxGeometry y="130" width="180" height="26" as="geometry" />
        </mxCell>
        
        <!-- Participant Entity -->
        <mxCell id="participant" value="Participant" style="swimlane;fontStyle=0;childLayout=stackLayout;horizontal=1;startSize=26;fillColor=#dae8fc;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;strokeColor=#6c8ebf;" parent="1" vertex="1">
          <mxGeometry x="310" y="440" width="180" height="156" as="geometry" />
        </mxCell>
        <mxCell id="participant-id" value="id UUID" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontStyle=4" parent="participant" vertex="1">
          <mxGeometry y="26" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="participant-tripId" value="tripId UUID (FK)" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="participant" vertex="1">
          <mxGeometry y="52" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="participant-userId" value="userId UUID (FK)" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="participant" vertex="1">
          <mxGeometry y="78" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="participant-role" value="role ENUM" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="participant" vertex="1">
          <mxGeometry y="104" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="participant-status" value="status ENUM" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="participant" vertex="1">
          <mxGeometry y="130" width="180" height="26" as="geometry" />
        </mxCell>
        
        <!-- Expense Entity -->
        <mxCell id="expense" value="Expense" style="swimlane;fontStyle=0;childLayout=stackLayout;horizontal=1;startSize=26;fillColor=#dae8fc;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;strokeColor=#6c8ebf;" parent="1" vertex="1">
          <mxGeometry x="50" y="440" width="180" height="182" as="geometry" />
        </mxCell>
        <mxCell id="expense-id" value="id UUID" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontStyle=4" parent="expense" vertex="1">
          <mxGeometry y="26" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="expense-tripId" value="tripId UUID (FK)" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="expense" vertex="1">
          <mxGeometry y="52" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="expense-title" value="title VARCHAR" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="expense" vertex="1">
          <mxGeometry y="78" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="expense-amount" value="amount DECIMAL" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="expense" vertex="1">
          <mxGeometry y="104" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="expense-paidById" value="paidById UUID (FK)" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="expense" vertex="1">
          <mxGeometry y="130" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="expense-category" value="category VARCHAR" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="expense" vertex="1">
          <mxGeometry y="156" width="180" height="26" as="geometry" />
        </mxCell>
        
        <!-- Vote Entity -->
        <mxCell id="vote" value="Vote" style="swimlane;fontStyle=0;childLayout=stackLayout;horizontal=1;startSize=26;fillColor=#dae8fc;horizontalStack=0;resizeParent=1;resizeParentMax=0;resizeLast=0;collapsible=1;marginBottom=0;strokeColor=#6c8ebf;" parent="1" vertex="1">
          <mxGeometry x="590" y="150" width="180" height="130" as="geometry" />
        </mxCell>
        <mxCell id="vote-id" value="id UUID" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;fontStyle=4" parent="vote" vertex="1">
          <mxGeometry y="26" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="vote-userId" value="userId UUID (FK)" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="vote" vertex="1">
          <mxGeometry y="52" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="vote-pointId" value="pointId UUID (FK)" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="vote" vertex="1">
          <mxGeometry y="78" width="180" height="26" as="geometry" />
        </mxCell>
        <mxCell id="vote-value" value="value INT" style="text;strokeColor=none;fillColor=none;align=left;verticalAlign=top;spacingLeft=4;spacingRight=4;overflow=hidden;rotatable=0;points=[[0,0.5],[1,0.5]];portConstraint=eastwest;" parent="vote" vertex="1">
          <mxGeometry y="104" width="180" height="26" as="geometry" />
        </mxCell>
        
        <!-- Relationships -->
        <!-- Trip -> User (Owner) -->
        <mxCell id="trip-user" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=1;exitY=0.5;exitDx=0;exitDy=0;entryX=0;entryY=0.5;entryDx=0;entryDy=0;endArrow=ERmany;endFill=0;startArrow=ERone;startFill=0;" edge="1" parent="1" source="user-id" target="trip-ownerId">
          <mxGeometry relative="1" as="geometry">
            <Array as="points">
              <mxPoint x="570" y="399" />
              <mxPoint x="570" y="350" />
              <mxPoint x="270" y="350" />
              <mxPoint x="270" y="395" />
            </Array>
          </mxGeometry>
        </mxCell>
        
        <!-- Trip -> Point -->
        <mxCell id="trip-point" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0;exitY=0.5;exitDx=0;exitDy=0;entryX=1;entryY=0.5;entryDx=0;entryDy=0;endArrow=ERmany;endFill=0;startArrow=ERone;startFill=0;" edge="1" parent="1" source="trip-id" target="point-id">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        
        <!-- Trip -> Participant -->
        <mxCell id="trip-participant" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0.5;exitY=1;exitDx=0;exitDy=0;entryX=0.5;entryY=0;entryDx=0;entryDy=0;endArrow=ERmany;endFill=0;startArrow=ERone;startFill=0;" edge="1" parent="1" source="trip" target="participant">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        
        <!-- User -> Participant -->
        <mxCell id="user-participant" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0;exitY=0.5;exitDx=0;exitDy=0;entryX=1;entryY=0.5;entryDx=0;entryDy=0;endArrow=ERmany;endFill=0;startArrow=ERone;startFill=0;" edge="1" parent="1" source="user-id" target="participant-userId">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        
        <!-- Trip -> Expense -->
        <mxCell id="trip-expense" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0;exitY=0.75;exitDx=0;exitDy=0;entryX=1;entryY=0.5;entryDx=0;entryDy=0;endArrow=ERmany;endFill=0;startArrow=ERone;startFill=0;" edge="1" parent="1" source="trip" target="expense-tripId">
          <mxGeometry relative="1" as="geometry">
            <Array as="points">
              <mxPoint x="280" y="356" />
              <mxPoint x="280" y="505" />
            </Array>
          </mxGeometry>
        </mxCell>
        
        <!-- User -> Expense -->
        <mxCell id="user-expense" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0;exitY=0.75;exitDx=0;exitDy=0;entryX=1;entryY=0.5;entryDx=0;entryDy=0;endArrow=ERmany;endFill=0;startArrow=ERone;startFill=0;" edge="1" parent="1" source="user" target="expense-paidById">
          <mxGeometry relative="1" as="geometry">
            <Array as="points">
              <mxPoint x="550" y="477" />
              <mxPoint x="550" y="583" />
            </Array>
          </mxGeometry>
        </mxCell>
        
        <!-- User -> Vote -->
        <mxCell id="user-vote" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0.5;exitY=0;exitDx=0;exitDy=0;entryX=0.5;entryY=1;entryDx=0;entryDy=0;endArrow=ERmany;endFill=0;startArrow=ERone;startFill=0;" edge="1" parent="1" source="user" target="vote">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        
        <!-- Point -> Vote -->
        <mxCell id="point-vote" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=1;exitY=0.25;exitDx=0;exitDy=0;entryX=0;entryY=0.5;entryDx=0;entryDy=0;endArrow=ERmany;endFill=0;startArrow=ERone;startFill=0;" edge="1" parent="1" source="point" target="vote-pointId">
          <mxGeometry relative="1" as="geometry">
            <Array as="points">
              <mxPoint x="260" y="259" />
              <mxPoint x="260" y="200" />
              <mxPoint x="540" y="200" />
              <mxPoint x="540" y="241" />
            </Array>
          </mxGeometry>
        </mxCell>
        
      </root>
    </mxGraphModel>
  </diagram>
</mxfile>
